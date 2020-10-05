using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MobileRechargeApiApp.BusinessLayer.Interface;
using MobileRechargeApiApp.BusinessLayer.Services;
using MobileRechargeApiApp.BusinessLayer.Services.Repository;
using MobileRechargeApiApp.DataLayer;
using MobileRechargeApiApp.DataLayer.Context;

namespace MobileRechargeApiApp
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.Configure<MongoDbSetting>(sp =>
            {
                sp.ConnectionString = Configuration.GetSection("MobileDatabaseSettings:ConnectionString").Value;
                sp.Database = Configuration.GetSection("MobileDatabaseSettings:Database").Value;
            });
            services.AddScoped<IMongoDbContext , MongoDbContext>();
            services.AddScoped<IPostpaidService, PostpaidService>();
            services.AddScoped<IPrepaidService, PrepaidService>();
            services.AddScoped<IPostpaidRepository, PostpaidRepository>();
            services.AddScoped<IPrepaidRepository, PrepaidRepository>();
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

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
