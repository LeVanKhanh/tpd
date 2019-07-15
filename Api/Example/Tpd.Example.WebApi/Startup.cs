using AutoMapper;
using ElmahCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using Tpd.Core.WebApi.StartupConfig;
using Tpd.Example.Data.Read;
using Tpd.Example.Data.Write;
using Tpd.Example.Domain;
using Tpd.Example.Domain.HandlerBase;

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
            services.AddMvcOptions();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,

                       ValidIssuer = "https://localhost:44393",
                       ValidAudience = "https://localhost:44393",
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
                   };
               });

            services.AddAutoMapper(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(DomainMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddMediatR(Assembly.GetExecutingAssembly(),
                Assembly.GetAssembly(typeof(DomainMediatorBase)),
                Assembly.GetAssembly(typeof(Core.Domain.RequestCore.RequestCore)));

            services.AddMySwagger(Configuration);

            services.AddDataWriteSql(Configuration, "DBConnectionWrite");
            services.AddDataReadSql(Configuration, "DBConnectionRead");

            services.AddDomain();
            //services.AddMultilanguage();
            services.AddMyElmah();
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
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseElmah();
            app.UseGlobalException();
            app.UseMvc();
            //app.UseMultilanguage();
        }
    }
}
