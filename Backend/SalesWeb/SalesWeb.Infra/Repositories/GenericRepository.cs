using Microsoft.EntityFrameworkCore;
using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Entities.Pagination;
using SalesWeb.Domain.Repositories;
using SalesWeb.Infra.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWeb.Infra.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly SalesContext _context;
        private readonly DbSet<T> _dataset;

        public GenericRepository(SalesContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            await _dataset.AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _context.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _dataset.ToListAsync();
        }

        public async Task<PagedResult<T>> FindAll(int CurrentPage, int PageSize)
        {
            return _dataset.GetPaged<T>(CurrentPage, PageSize);
        }

        public async Task<T> FindById(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
            return entity;
        }

        private async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
