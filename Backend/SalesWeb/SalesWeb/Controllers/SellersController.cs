using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Domain.DTO;
using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Handlers.Interfaces;

namespace SalesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly ISellerHandler sellerHandler;

        public SellersController(ISellerHandler sellerHandler)
        {
            this.sellerHandler = sellerHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSellers()
        {
            return Ok(await sellerHandler.FindAll());
        }

        [HttpGet("{sellerId}")]
        public async Task<IActionResult> GetSellerById(Guid sellerId)
        {
            return Ok(await sellerHandler.FindById(sellerId));
        }

        [HttpPost]
        public async Task<IActionResult> AddSeller(SellerDto seller)
        {
            return Ok(await sellerHandler.Add(seller));
        }

        [HttpPut("sellerId")]
        public async Task<IActionResult> AlterSeller(Guid sellerId)
        {
            return Ok(await sellerHandler.Update(sellerId));
        }

        [HttpDelete("sellerId")]
        public async Task<IActionResult> DeleteSeller(Guid sellerId)
        {
            return Ok(await sellerHandler.Delete(sellerId));
        }
    }
}