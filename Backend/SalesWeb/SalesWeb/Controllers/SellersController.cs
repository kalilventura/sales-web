using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Domain.DTO;
using SalesWeb.Domain.Handlers.Interfaces;

namespace SalesWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellersController : ControllerBase
    {
        private readonly ISellerHandler sellerHandler;

        public SellersController(ISellerHandler sellerHandler)
        {
            this.sellerHandler = sellerHandler;
        }

        [HttpGet("AllSellers")]
        public async Task<IActionResult> AllSellers()
        {
            return Ok(await sellerHandler.FindAll());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSellers(int currentPage, int pageSize)
        {
            return Ok(await sellerHandler.FindAll(currentPage, pageSize));
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

        [HttpPut]
        public async Task<IActionResult> AlterSeller(SellerDto seller)
        {
            return Ok(await sellerHandler.Update(seller));
        }

        [HttpDelete("sellerId")]
        public async Task<IActionResult> DeleteSeller(Guid sellerId)
        {
            return Ok(await sellerHandler.Delete(sellerId));
        }
    }
}