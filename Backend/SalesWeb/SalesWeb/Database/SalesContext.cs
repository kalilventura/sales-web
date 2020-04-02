using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SalesWeb.Domain.Entities;

namespace SalesWeb.Database
{
    public class SalesContext : DbContext
    {
        private IConfiguration Configuration { get; }

        public SalesContext(DbContextOptions<SalesContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = Configuration["ConnectionStrings:SqlServer"];
            optionsBuilder
                .UseSqlServer(connectionString,
                    options =>
                    {
                        options.EnableRetryOnFailure(2);
                        //options.MigrationsAssembly("SalesWeb.Infra");
                    });

            base.OnConfiguring(optionsBuilder);
        }
    }
}
