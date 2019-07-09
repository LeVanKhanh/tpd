using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.Data;

namespace Tpd.Language.Data
{
    public static class DataBuilderHelper
    {
        public static void AddDataReadSql(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
                => DataBuilderHelperCore.AddDataSql<DatabaseContext>(services, configuration, connectionStringName);

        public static void AddDataReadSqlite<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            => DataBuilderHelperCore.AddDataSqlite<DatabaseContext>(services, configuration, connectionStringName);

        public static void AddDataReadInMemory<TDatabaseContext>(this IServiceCollection services, string dataBaseName)
            => DataBuilderHelperCore.AddDataInMemory<DatabaseContext>(services, dataBaseName);
    }
}
