using SalesWeb.Domain.DTO;
using SalesWeb.Domain.Entities;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Handlers.Interfaces
{
    public interface IDepartmentHandler : IGenericHandler<Department>
    {
        Task<IGenericResult> Add(DepartmentDto entity);
        Task<IGenericResult> Update(DepartmentDto departmentDto);
    }
}
