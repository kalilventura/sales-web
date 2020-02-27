using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ListAllDepartments()
        {
            return StatusCode(StatusCodes.Status200OK, new { message = "works" });
        }

        [HttpPost]
        public async Task<IActionResult> SaveDepartment()
        {
            return StatusCode(StatusCodes.Status200OK, new { message = "works" });
        }

        [HttpPut]
        public async Task<IActionResult> EditDepartment()
        {
            return StatusCode(StatusCodes.Status200OK, new { message = "works" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment()
        {
            return StatusCode(StatusCodes.Status200OK, new { message = "works" });
        }
    }
}