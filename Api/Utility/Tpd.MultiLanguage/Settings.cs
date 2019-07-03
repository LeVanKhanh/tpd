using Microsoft.Extensions.Configuration;

namespace Tpd.MultiLanguage
{
    public class Settings
    {
        private static IConfigurationSection _configuration;
        private static string _applicationName;
        private static string _queueName;
        private static string _hostName;

        public Settings(IConfiguration configuration)
        {
            if (_configuration == null)
            {
                _configuration = configuration.GetSection("LanguageService");
                GetSetting();
            }
        }

        private void GetSetting()
        {
            _queueName = _configuration["QueueName"];//"rpc_queue";
            _hostName = _configuration["HostName"];// "localhost";
            _applicationName = _configuration["ApplicationName"];//Ex
        }

        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
        }

        public string QueueName
        {
            get
            {
                return _queueName;
            }
        }

        public string HostName
        {
            get
            {
                return _hostName;
            }
        }
    }
}
