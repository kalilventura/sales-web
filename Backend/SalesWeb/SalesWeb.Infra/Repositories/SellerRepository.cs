using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Repositories;

namespace SalesWeb.Infra.Repositories
{
    public class SellerRepository : GenericRepository<Seller>, ISellerRepository
    {
        public SellerRepository(SalesContext context):base(context) { }
    }
}