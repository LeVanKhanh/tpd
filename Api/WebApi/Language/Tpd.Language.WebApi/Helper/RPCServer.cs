using MediatR;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Domain.TranslationDomain.Request;
using Tpd.Language.Domain.TranslationDomain.Result;

namespace Tpd.Language.WebApi.Helper
{
    public static class RPCServer
    {
        private const string QUEUE_NAME = "rpc_queue";
        private static IConnection connection;
        private static IModel channel;

        public static void AddRPCServer(this IApplicationBuilder app, IMediator mediator)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.QueueDeclare(queue: "rpc_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);
            channel.BasicQos(0, 1, false);
            var consumer = new EventingBasicConsumer(channel);
            channel.BasicConsume(queue: "rpc_queue", autoAck: false, consumer: consumer);

            consumer.Received += (model, ea) =>
            {
                string response = null;

                var body = ea.Body;
                var props = ea.BasicProperties;
                var replyProps = channel.CreateBasicProperties();
                replyProps.CorrelationId = props.CorrelationId;

                try
                {

                    var message = Encoding.UTF8.GetString(body);
                    var query = JsonConvert.DeserializeObject<GetTranslationsQuery>(message);
                    var handlerTask = mediator.Send<IResultCore<PagedResultCore<ResoureEntryModel>>>(query);
                    handlerTask.Wait();
                    var handlerResult = handlerTask.Result;
                    if (handlerResult != null && handlerResult.Success)
                    {
                        response = JsonConvert.SerializeObject(handlerResult.Result.Result);
                    }
                }
                catch (Exception e)
                {
                    response = e.Message;
                }
                finally
                {
                    var responseBytes = Encoding.UTF8.GetBytes(response);
                    channel.BasicPublish(exchange: "", routingKey: props.ReplyTo, basicProperties: replyProps, body: responseBytes);
                    channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                }
            };
        }
    }
}
