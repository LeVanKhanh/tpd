using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System;
using System.Reflection;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Core.Domain.RequestCore.QueryCore;

namespace Tpd.Core.Domain
{
    public static class DomainBuilderHelperCore
    {
        public static void AddDomain(this IServiceCollection services, Type domainType, params Type[] commands)
        {
            services.AddTransient(typeof(ICommandCreateCore<>), typeof(CommandCreateCore<>));
            services.AddTransient(typeof(ICommandUpdateCore<>), typeof(CommandUpdateCore<>));
            services.AddTransient(typeof(ICommandRemoveCore), typeof(CommandRemoveCore));
            services.AddTransient(typeof(IQueryByIdCore<>), typeof(QueryByIdCore<>));

            foreach (var command in commands)
            {
                services.AddTransient(command);
            }

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(domainType))
                  .Where(c => c.Name.EndsWith("HandlerMediator"))
                  .AsPublicImplementedInterfaces();
        }
    }
}
