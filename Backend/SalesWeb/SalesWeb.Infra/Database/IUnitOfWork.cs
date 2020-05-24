using System.Threading.Tasks;

namespace SalesWeb.Infra.Database
{
    public interface IUnitOfWork
    {
        Task BeginTransaction();
        Task EndTransaction();
        Task Rollback();
    }
}
