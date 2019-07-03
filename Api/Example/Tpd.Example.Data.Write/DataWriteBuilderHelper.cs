using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.Data;

namespace Tpd.Example.Data.Write
{
    public static class DataWriteBuilderHelper
    {
        public static void AddDataWriteSql(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            => DataBuilderHelperCore.AddDataSql<DatabaseWriteContext>(services, configuration, connectionStringName);

        public static void AddDataWriteSqlite<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            => DataBuilderHelperCore.AddDataSqlite<DatabaseWriteContext>(services, configuration, connectionStringName);

        public static void AddDataWriteInMemory<TDatabaseContext>(this IServiceCollection services, string dataBaseName)
            => DataBuilderHelperCore.AddDataInMemory<DatabaseWriteContext>(services, dataBaseName);
    }
}
