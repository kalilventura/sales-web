using Microsoft.EntityFrameworkCore;
using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Repositories;
using System.Threading.Tasks;

namespace SalesWeb.Infra.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SalesContext context) : base(context) { }

        public async Task<Department> FindDepartmentByName(string departmentName)
        {
            return await _context.Department.FirstOrDefaultAsync(x => x.Name.Equals(departmentName));
        }
    }
}
