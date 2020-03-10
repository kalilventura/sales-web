using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesRecordController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            return Ok();
        }
    }
}