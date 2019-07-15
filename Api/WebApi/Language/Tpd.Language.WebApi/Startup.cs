using AutoMapper;
using ElmahCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tpd.Core.WebApi.StartupConfig;
using Tpd.Language.Data;
using Tpd.Language.Domain;
using Tpd.Language.Domain.HandlerBase;
using Tpd.Language.Domain.TranslationDomain.Handler;
using Tpd.Language.WebApi.Helper;

namespace Tpd.Language.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcOptions();

            services.AddDataSql(Configuration, "DBConnection");

            services.AddAutoMapper(Assembly.GetExecutingAssembly(),
               Assembly.GetAssembly(typeof(DomainMediatorBase)),
               Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddMediatR(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(DomainMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddMySwagger(Configuration);
            services.AddDomain();
            services.AddMyElmah();
            services.AddScoped<GetTranslationsHandler>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseMySwagger();
            app.UseHttpsRedirection();
            app.UseElmah();
            app.UseGlobalException();
            app.UseMvc();
            app.AddRPCServer();
        }
    }
}
