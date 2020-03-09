using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Repositories;
using SalesWeb.Infra.Database;

namespace SalesWeb.Infra.Repositories
{
    public class SalesRecordRepository : ISalesRecordRepository
    {
        private readonly Context _context;

        public SalesRecordRepository(Context context)
        {
            _context = context;
        }

        public async Task Add(SalesRecord entity)
        {
            await _context.SalesRecord.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(SalesRecord entity)
        {
            _context.SalesRecord.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SalesRecord>> FindAll()
        {
            return await _context.SalesRecord.ToListAsync();
        }

        public async Task<IEnumerable<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            IQueryable<SalesRecord> result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
                result = result.Where(x => x.Date >= minDate.Value);

            if (maxDate.HasValue)
                result = result.Where(x => x.Date <= maxDate.Value);

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
                result = result.Where(x => x.Date >= minDate.Value);

            if (maxDate.HasValue)
                result = result.Where(x => x.Date <= maxDate.Value);

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .ToListAsync();
        }

        public async Task<SalesRecord> FindById(Guid id)
        {
            return await _context.SalesRecord.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(SalesRecord entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}