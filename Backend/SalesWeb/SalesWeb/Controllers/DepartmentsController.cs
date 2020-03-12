using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.DTO;

namespace SalesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            return Ok();
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> GetDepartmentById(Guid departmentId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentDTO department)
        {
            return Ok("Deu certo");
        }

        [HttpPut("{departmentId}")]
        public async Task<IActionResult> AlterDepartment(Guid departmentId)
        {
            return Ok();
        }

        [HttpDelete("{departmentId}")]
        public async Task<IActionResult> DeleteDepartment(Guid departmentId)
        {
            return Ok();
        }
    }
}