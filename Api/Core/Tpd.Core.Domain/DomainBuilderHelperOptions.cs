using Microsoft.Extensions.Configuration;

namespace Tpd.Core.Domain
{
    public class DomainBuilderHelperOptions
    {
        public IConfiguration configuration { get; set; }
        public string ConnectionStringName { get; set; }
        public string DataBaseName { get; set; }
        public DataTypeProvider DataProvider { get; set; }
        public enum DataTypeProvider
        {
            Sql = 0,
            Sqlite,
            InMemmory
        }
    }
}
