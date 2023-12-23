﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationManagementSystem.Core.Utilities.IoC
{
    public static class ServiceTools
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IServiceCollection Create(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
