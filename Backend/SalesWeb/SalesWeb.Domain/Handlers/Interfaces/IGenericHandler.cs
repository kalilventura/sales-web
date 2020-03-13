﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Handlers.Interfaces
{
    public interface IGenericHandler<T> where T : class
    {
        Task<IGenericResult> FindAll();
        Task<IGenericResult> FindById(Guid id);
        Task<IGenericResult> Add(T entity);
        Task<IGenericResult> Update(T entity);
        Task<IGenericResult> Delete(T entity);
    }
}
