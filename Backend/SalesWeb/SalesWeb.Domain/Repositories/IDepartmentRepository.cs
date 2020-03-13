using SalesWeb.Domain.Entities;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Repositories
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        Task<Department> FindDepartmentByName(string departmentName);
    }
}
