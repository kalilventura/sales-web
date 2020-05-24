using Microsoft.Extensions.DependencyInjection;
using SalesWeb.Domain.Handlers;
using SalesWeb.Domain.Handlers.Interfaces;
using SalesWeb.Domain.Repositories;
using SalesWeb.Infra.Database;
using SalesWeb.Infra.Repositories;

namespace SalesWeb.Configurations
{
    public static class DependencyInjection
    {
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();            
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }

        private static void AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<IDepartmentHandler, DepartmentHandler>();
            services.AddTransient<ISellerHandler, SellerHandler>();            
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<SeedingService>();

            AddRepositories(services);
            AddHandlers(services);
            
            return services;
        }
    }
}