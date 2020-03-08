using Microsoft.EntityFrameworkCore;
using SalesWeb.Domain.Entities;

namespace SalesWeb.Database.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
