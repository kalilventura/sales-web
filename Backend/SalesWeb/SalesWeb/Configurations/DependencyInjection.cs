﻿using Microsoft.Extensions.DependencyInjection;
using SalesWeb.Domain.Handlers;
using SalesWeb.Domain.Handlers.Interfaces;
using SalesWeb.Domain.Repositories;
using SalesWeb.Repositories;

namespace SalesWeb.Configurations
{
    public static class DependencyInjection
    {
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
        }

        private static void AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<IDepartmentHandler, DepartmentHandler>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            AddRepositories(services);
            AddHandlers(services);
            return services;
        }
    }
}
