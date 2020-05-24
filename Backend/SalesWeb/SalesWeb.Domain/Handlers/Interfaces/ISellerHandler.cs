using SalesWeb.Domain.DTO;
using SalesWeb.Domain.Entities;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Handlers.Interfaces
{
    public interface ISellerHandler : IGenericHandler<Seller>
    {
        Task<IGenericResult> Add(SellerDto sellerDto);
        Task<IGenericResult> Update(SellerDto sellerDto);
    }
}