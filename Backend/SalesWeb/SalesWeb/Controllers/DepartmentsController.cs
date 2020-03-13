using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Domain.Handlers.Interfaces;
using SalesWeb.DTO;

namespace SalesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> AddDepartment(DepartmentDTO department)
        {
            return Ok();
        }

        [HttpPut("{departmentId}")]
        public async Task<IActionResult> AlterDepartment(Guid departmentId)
        {
            var result = await departmentHandler.Update(departmentId);
            return Ok();
        }

        [HttpDelete("{departmentId}")]
        public async Task<IActionResult> DeleteDepartment(Guid departmentId)
        {
            return Ok();
        }
    }
}