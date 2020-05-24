using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesWeb.Infra.Repositories;
using System.Threading.Tasks;

namespace SalesWeb.Infra.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalesContext context;

        private IDbContextTransaction transaction;

        public UnitOfWork(SalesContext context)
        {
            this.context = context;
        }

        private async Task Commit() => await transaction.CommitAsync();
        private async Task SaveChangesAsync() => await context.SaveChangesAsync();

        public async Task BeginTransaction()
        {
            transaction = await context.Database.BeginTransactionAsync();
        }

        public async Task Rollback()
        {
            await transaction.RollbackAsync();
        }

        public async Task EndTransaction()
        {
            await SaveChangesAsync();
            await Commit();
        }

    }
}
