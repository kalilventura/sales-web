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
    public class SellersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllSellers()
        {
            return Ok();
        }

        [HttpGet("{sellerId}")]
        public async Task<IActionResult> GetSellerById(Guid sellerId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddSeller(SellerDTO seller)
        {
            return Ok();
        }

        [HttpPut("sellerId")]
        public async Task<IActionResult> AlterSeller(Guid sellerId)
        {
            return Ok();
        }

        [HttpDelete("sellerId")]
        public async Task<IActionResult> DeleteSeller(Guid sellerId)
        {
            return Ok();
        }
    }
}