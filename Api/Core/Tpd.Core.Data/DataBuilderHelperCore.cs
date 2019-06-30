using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tpd.Core.Data
{
    public static class DataBuilderHelperCore
    {
        public static void AddDataSql<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddDbContext<TDatabaseContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
        }

        public static void AddDataSqlite<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddDbContext<TDatabaseContext>(options =>
                 options.UseSqlite(configuration.GetConnectionString(connectionStringName)));
        }

        public static void AddDataInMemory<TDatabaseContext>(this IServiceCollection services, string dataBaseName)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddDbContext<TDatabaseContext>(options => options.UseInMemoryDatabase(dataBaseName));
        }
    }
}
