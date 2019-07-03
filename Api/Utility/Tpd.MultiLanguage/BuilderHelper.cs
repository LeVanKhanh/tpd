using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Tpd.MultiLanguage
{
    public static class BuilderHelper
    {
        private static bool _isUseDefaultService { get; set; }

        public static void AddMultilanguage(this IServiceCollection services, bool isUseDefaultService = true)
        {
            _isUseDefaultService = isUseDefaultService;

            services.AddTransient<IResourceStore, ResourceStore>();
            services.AddTransient<ResourceBuilder>();
            if (isUseDefaultService == true)
            {
                services.AddTransient<Settings>();
                services.AddTransient<RpcClient>();
                services.AddTransient<IResourceService, ResourceService>();
            }
        }

        public static void UseMultilanguage(this IApplicationBuilder app)
        {
            var languageCache = app.ApplicationServices.GetService<ResourceBuilder>();
            languageCache.CreateCache();
        }
    }
}
