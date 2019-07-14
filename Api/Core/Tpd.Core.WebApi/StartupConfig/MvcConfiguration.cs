using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.WebApi.Filters;

namespace Tpd.Core.WebApi.StartupConfig
{
    public static class MvcConfiguration
    {
        public static void AddMvcOptions(this IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(new ActionExceptionFilterAttribute());
                options.Filters.Add(new ActionFilterAttribute());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
            .AddFluentValidation();
        }
    }
}
