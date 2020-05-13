using SalesWeb.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Handlers.Interfaces
{
    public interface IGenericHandler<T> where T : BaseEntity
    {
        Task<IGenericResult> FindAll();
        Task<IGenericResult> FindAll(int currentPage, int pageSize);
        Task<IGenericResult> FindById(Guid id);
        Task<IGenericResult> Update(Guid id);
        Task<IGenericResult> Delete(Guid id);
    }
}