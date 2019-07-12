using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tpd.Core.WebApi.StartupConfig;
using Tpd.Language.Data;
using Tpd.Language.Domain;
using Tpd.Language.Domain.HandlerBase;
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDataSql(Configuration, "DBConnection");

            services.AddAutoMapper(Assembly.GetExecutingAssembly(),
               Assembly.GetAssembly(typeof(DomainMediatorBase)),
               Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddMediatR(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(DomainMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddSwagger(Configuration);
            services.AddDomain();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IMediator mediator)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.AddRPCServer(mediator);
        }
    }
}
