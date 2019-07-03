using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tpd.Example.Data.Write;
using Tpd.Example.Domain;
using Tpd.Example.Domain.HandlerBase;
using Tpd.Example.WebApi.StartupConfig;

namespace Tpd.Example.WebApi
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

            services.AddAutoMapper(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(DomainMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddMediatR(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(DomainMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddSwagger(Configuration);
            services.AddDataSql(Configuration, "DBConnectionWrite");
            services.AddDomain();
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
            app.UseSwagger();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
