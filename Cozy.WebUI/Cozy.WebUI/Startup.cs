﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cozy.Domain.Models;
using Cozy.Service.Services;
using CozyData.Context;
using CozyData.Implmentation.EFCore;
using CozyData.Implmentation.Mock;
using CozyData.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cozy.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // bad way of adding connection string
            // TODO: fix it later
            // var connectionString = "Data Source = (localdb)\\ProjectsV13; Initial Catalog = cozy; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            // services.AddDbContext<CozyDbContext>(options => options.UseSqlServer(connectionString));

            // Repository Layer
            // GetDependencyResolvedForMockRepositoryLayer(services);
            GetDependencyResolvedForEFCoreRepositoryLayer(services);
            

            // Service Layer
            GetDependencyResolvedForServiceLayer(services);


            // Identity
            services.AddDbContext<CozyDbContext>();
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<CozyDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/SignIn";  // overrides the default for /account/login
                options.AccessDeniedPath = "/Account/Unauthorized";
            });

            // Homework is to find out how to set different options for password
            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.
            //});
            services.AddMvc();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseAuthentication();    // makes use of Identity
                
            app.UseMvcWithDefaultRoute();
            // controller/view/?id
            // Home/index/?id
        }
        

        private void GetDependencyResolvedForMockRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<IHomeRepository, MockHomeRepository>();
            services.AddScoped<ILeaseRepository, MockLeaseRepository>();
            services.AddScoped<IMaintenanceRepository, MockMaintenanceRepository>();
            services.AddScoped<IMaintenanceStatusRepository, MockMaintenanceStatusRepository>();

        }

        private void GetDependencyResolvedForEFCoreRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<IHomeRepository, EFCoreHomeRepository>();
            services.AddScoped<ILeaseRepository, EFCoreLeaseRepository>();
            services.AddScoped<IMaintenanceRepository, EFCoreMaintenanceRepository>();
            services.AddScoped<IPaymentRepository, EFCorePaymentRepository>();
            services.AddScoped<IMaintenanceStatusRepository, EFCoreMaintenanceStatusRepository>();
        }

        private void GetDependencyResolvedForServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<ILeaseService, LeaseService>();
            services.AddScoped<IMaintenanceService, MaintenanceService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IMaintenanceStatusService, MaintenanceStatusService>();
        }
    }
}
