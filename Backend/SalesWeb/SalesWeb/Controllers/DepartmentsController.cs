using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Handlers.Interfaces;
using SalesWeb.DTO;

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

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var departments = await departmentHandler.FindAll();
            return Ok(departments);
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> GetDepartmentById(Guid departmentId)
        {
            var departments = await departmentHandler.FindById(departmentId);
            return Ok(departments);
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentDto department)
        {
            var newDepartment = new Department(department.Name);
            var result = await departmentHandler.Add(newDepartment);
            return Ok(result);
        }

        [HttpPut("{departmentId}")]
        public async Task<IActionResult> AlterDepartment(Guid departmentId)
        {
            var result = await departmentHandler.Update(departmentId);
            return Ok(result);
        }

        [HttpDelete("{departmentId}")]
        public async Task<IActionResult> DeleteDepartment(Guid departmentId)
        {
            var result = await departmentHandler.Delete(departmentId);
            return Ok(result);
        }
    }
}
