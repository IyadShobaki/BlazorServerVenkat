﻿using System;
using EmployeeManagementWeb.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EmployeeManagementWeb.Areas.Identity.IdentityHostingStartup))]
namespace EmployeeManagementWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EmployeeManagementWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EmployeeManagementWebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EmployeeManagementWebContext>();
            });
        }
    }
}