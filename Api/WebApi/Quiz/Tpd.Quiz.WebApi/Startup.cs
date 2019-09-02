using AutoMapper;
using ElmahCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using Tpd.Core.WebApi.StartupConfig;
using Tpd.Quiz.Data;
using Tpd.Quiz.Handler;
using Tpd.Quiz.Handler.HandlerBase;

namespace Tpd.Quiz.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcOptions();

            services.AddAutoMapper(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(HandlerMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Handler.RequestCore.RequestCore)));

            services.AddMediatR(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(HandlerMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Handler.RequestCore.RequestCore)));

            services.AddMySwagger(Configuration);

            services.AddDataSql(Configuration, "DBConnection");

            services.AddDomain();
            services.AddMyElmah();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseMySwagger();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseElmah();
            app.UseGlobalException();
            app.UseMvc();
        }
    }
}
