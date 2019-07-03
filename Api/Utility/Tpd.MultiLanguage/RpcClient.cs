using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tpd.MultiLanguage
{
    public class RpcClient
    {
        private readonly IConnection connection;
        private readonly IModel channel;
        private readonly string replyQueueName;
        private readonly EventingBasicConsumer consumer;
        private readonly ConcurrentDictionary<string, TaskCompletionSource<List<ResourceEntry>>> callbackMapper =
                    new ConcurrentDictionary<string, TaskCompletionSource<List<ResourceEntry>>>();
        private readonly Settings _settings;

        public RpcClient(Settings settings)
        {
            _settings = settings;

            var factory = new ConnectionFactory() { HostName = _settings.HostName };

            connection = factory.CreateConnection();
            channel = connection.CreateModel();
            replyQueueName = channel.QueueDeclare().QueueName;
            consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                if (!callbackMapper.TryRemove(ea.BasicProperties.CorrelationId, out TaskCompletionSource<List<ResourceEntry>> tcs))
                    return;
                var body = ea.Body;
                var response = Encoding.UTF8.GetString(body);
                var result = JsonConvert.DeserializeObject<List<ResourceEntry>>(response);
                tcs.TrySetResult(result);
            };
        }

        public Task<List<ResourceEntry>> CallAsync(string application, string module, string culture, CancellationToken cancellationToken = default(CancellationToken))
        {
            IBasicProperties props = channel.CreateBasicProperties();
            var correlationId = Guid.NewGuid().ToString();
            props.CorrelationId = correlationId;
            props.ReplyTo = replyQueueName;
            //props.Expiration = "60000";

            var requestModel = new RequestLanguageModel
            {
                Application = application,
                Module = module,
                Culture = culture
            };

            var message = JsonConvert.SerializeObject(requestModel);
            var messageBytes = Encoding.UTF8.GetBytes(message);
            var tcs = new TaskCompletionSource<List<ResourceEntry>>();
            callbackMapper.TryAdd(correlationId, tcs);

            channel.BasicPublish(
                exchange: "",
                routingKey: _settings.QueueName,
                basicProperties: props,
                body: messageBytes);

            channel.BasicConsume(
                consumer: consumer,
                queue: replyQueueName,
                autoAck: true);

            cancellationToken.Register(() => callbackMapper.TryRemove(correlationId, out var tmp));
            return tcs.Task;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
