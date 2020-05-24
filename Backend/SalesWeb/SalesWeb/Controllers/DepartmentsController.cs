using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Domain.DTO;
using SalesWeb.Domain.Handlers.Interfaces;

namespace SalesWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentHandler departmentHandler;

        public DepartmentsController(IDepartmentHandler departmentHandler)
        {
            this.departmentHandler = departmentHandler;
        }

        [HttpGet("AllDepartments")]
        public async Task<IActionResult> AllDepartments()
        {
            return Ok(await departmentHandler.FindAll());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments(int currentPage, int pageSize)
        {
            return Ok(await departmentHandler.FindAll(currentPage, pageSize));
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> GetDepartmentById(string departmentId)
        {
            return Ok(await departmentHandler.FindById(new Guid(departmentId)));
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentDto department)
        {
            return Ok(await departmentHandler.Add(department));
        }

        [HttpPut("{departmentId}")]
        public async Task<IActionResult> AlterDepartment(Guid departmentId)
        {
            return Ok(await departmentHandler.Update(departmentId));
        }

        [HttpDelete("{departmentId}")]
        public async Task<IActionResult> DeleteDepartment(Guid departmentId)
        {
            return Ok(await departmentHandler.Delete(departmentId));
        }
    }
}