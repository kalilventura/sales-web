using Microsoft.EntityFrameworkCore;
using SalesWeb.Domain.Entities;

namespace SalesWeb.Infra.Repositories
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
