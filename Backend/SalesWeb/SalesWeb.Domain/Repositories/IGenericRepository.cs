﻿using SalesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(Guid id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
