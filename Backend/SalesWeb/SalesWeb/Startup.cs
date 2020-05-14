using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalesWeb.Configurations;
using SalesWeb.Filters;
using SalesWeb.Infra.Repositories;
using SalesWeb.Middlewares;

namespace SalesWeb
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
            services.AddDbContext<SalesContext>(optionsBuilder =>
            optionsBuilder
                .UseSqlServer(Configuration["ConnectionStrings:SqlServer"],
                    options =>
                    {
                        options.EnableRetryOnFailure(2);
                        options.MigrationsAssembly("SalesWeb.Infra");
                    }));

            services
                .AddControllers(x =>
                {
                    x.Filters.Add(typeof(ValidatorActionFilterAttribute));
                }).AddNewtonsoftJson(option =>
                {
                    option.AllowInputFormatterExceptionMessages = true;
                })
                .AddJsonOptions(x =>
                {
                    x.JsonSerializerOptions.IgnoreNullValues = true;
                })
                .AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddServices();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseExceptionHandlerMiddleware();
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AllowAllHeaders");

            app.UseAuthorization();

            // app.UseMiddleware<RequestResponseLoggingMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}