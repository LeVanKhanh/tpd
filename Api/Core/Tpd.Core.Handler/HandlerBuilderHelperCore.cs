using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System;
using System.Reflection;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.RequestCore.CommandCore;
using Tpd.Core.Handler.RequestCore.QueryCore;

namespace Tpd.Core.Handler
{
    public static class HandlerBuilderHelperCore
    {
        public static void AddDomain(this IServiceCollection services, Type domainType, params Type[] commands)
        {
            services.AddTransient(typeof(ICommandCreateCore<>), typeof(CommandCreateCore<>));
            services.AddTransient(typeof(ICommandUpdateCore<>), typeof(CommandUpdateCore<>));
            services.AddTransient(typeof(ICommandRemoveCore), typeof(CommandRemoveCore));
            services.AddTransient(typeof(IQueryItemCore<>), typeof(QueryItemCore<>));
            services.AddTransient<IValidationService, FluentValidationService>();

            foreach (var command in commands)
            {
                services.AddTransient(command);
            }

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(domainType))
                  .Where(c => c.Name.EndsWith("HandlerMediator"))
                  .AsPublicImplementedInterfaces();

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(domainType))
                  .Where(c => c.Name.EndsWith("Validator"))
                  .AsPublicImplementedInterfaces();

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetAssembly(domainType))
                  .Where(c => c.Name.EndsWith("Notifcation"))
                  .AsPublicImplementedInterfaces();
        }
    }
}
