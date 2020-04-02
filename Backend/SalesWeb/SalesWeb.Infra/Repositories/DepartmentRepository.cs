using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Infra.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly SalesContext _context;

        public DepartmentRepository(SalesContext context)
        {
            _context = context;
        }

        public async Task Add(Department entity)
        {
            await _context.Department.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Department entity)
        {
            _context.Department.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Department>> FindAll()
        {
            return await _context.Department.ToListAsync();
        }

        public async Task<Department> FindById(Guid id)
        {
            return await _context.Department.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Department> FindDepartmentByName(string departmentName)
        {
            return await _context.Department.FirstOrDefaultAsync(x => x.Name.Equals(departmentName));
        }

        public async Task Update(Department entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
