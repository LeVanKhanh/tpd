using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.Data;

namespace Tpd.Example.Data.Read
{
    public static class DataReadBuilderHelper
    {
        public static void AddDataReadSql(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            => DataBuilderHelperCore.AddDataSql<DatabaseReadContext>(services, configuration, connectionStringName);

        public static void AddDataReadSqlite<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            => DataBuilderHelperCore.AddDataSqlite<DatabaseReadContext>(services, configuration, connectionStringName);

        public static void AddDataReadInMemory<TDatabaseContext>(this IServiceCollection services, string dataBaseName)
            => DataBuilderHelperCore.AddDataInMemory<DatabaseReadContext>(services, dataBaseName);
    }
}
