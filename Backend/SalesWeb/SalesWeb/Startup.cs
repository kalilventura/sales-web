using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SalesWeb.Domain.Handlers;
using SalesWeb.Domain.Handlers.Interfaces;
using SalesWeb.Domain.Repositories;
using SalesWeb.Filters;
using SalesWeb.Infra.Database;
using SalesWeb.Infra.Repositories;
using SalesWeb.Middlewares;
using System;

namespace SalesWeb
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
            services
                .AddDbContext<Context>(option =>
                   option.UseMySql(Configuration["ConnectionStrings:MySQLConnectionString"],
                   mySqlOptions =>
                   {
                       mySqlOptions.ServerVersion(new Version(8, 5), ServerType.MySql);
                       mySqlOptions.EnableRetryOnFailure(2);
                       mySqlOptions.CharSetBehavior(CharSetBehavior.AppendToAllColumns);
                       mySqlOptions.MigrationsAssembly("SalesWeb.Infra");
                   }));

            services
                .AddControllers(
                //x =>
                //{
                //    x.Filters.Add(typeof(ValidatorActionFilter));
                //}
                )
                .AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddTransient<IDepartmentHandler, DepartmentHandler>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseExceptionHandlerMiddleware();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
