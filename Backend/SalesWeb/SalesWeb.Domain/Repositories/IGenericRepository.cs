using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> FindAll();
        Task<PagedResult<T>> FindAll(int CurrentPage, int PageSize);
        Task<T> FindById(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
