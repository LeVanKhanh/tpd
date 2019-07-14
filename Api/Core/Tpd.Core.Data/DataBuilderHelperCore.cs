using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System.Reflection;

namespace Tpd.Core.Data
{
    public static class DataBuilderHelperCore
    {
        public static void AddDataSql<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddDbContext<TDatabaseContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
            services.AddCommon<TDatabaseContext>();
        }

        public static void AddDataSqlite<TDatabaseContext>(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddDbContext<TDatabaseContext>(options =>
                 options.UseSqlite(configuration.GetConnectionString(connectionStringName)));
            services.AddCommon<TDatabaseContext>();
        }

        public static void AddDataInMemory<TDatabaseContext>(this IServiceCollection services, string dataBaseName)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddDbContext<TDatabaseContext>(options => options.UseInMemoryDatabase(dataBaseName));
            services.AddCommon<TDatabaseContext>();
        }

        private static void AddCommon<TDatabaseContext>(this IServiceCollection services)
            where TDatabaseContext : DatabaseContextCore
        {
            services.AddTransient<TDatabaseContext>();
            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(typeof(TDatabaseContext)))
                  .Where(c => c.Name.EndsWith("Validator"))
                  .AsPublicImplementedInterfaces();
        }
    }
}
