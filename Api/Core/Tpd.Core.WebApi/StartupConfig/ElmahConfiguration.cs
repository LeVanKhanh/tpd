using ElmahCore;
using ElmahCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Tpd.Core.WebApi.StartupConfig
{
    public static class ElmahConfiguration
    {
        /// <summary>
        /// The function for Elmah configuration
        /// </summary>
        /// <param name="services"></param>
        public static void AddMyElmah(this IServiceCollection services)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "logs");
            services.AddElmah<XmlFileErrorLog>(options =>
            {
                options.LogPath = path;// The path to write file
                options.Path = @"Elmah";// the route name
            });
        }
    }
}
