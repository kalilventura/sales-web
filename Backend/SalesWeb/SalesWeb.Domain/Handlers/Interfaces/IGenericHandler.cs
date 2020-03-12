using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Handlers.Interfaces
{
    public interface IGenericHandler<T> where T : class
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(Guid id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
