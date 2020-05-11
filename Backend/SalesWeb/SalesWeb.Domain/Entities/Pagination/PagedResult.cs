using System.Collections.Generic;

namespace SalesWeb.Domain.Entities.Pagination
{
    public class PagedResult<T> : BasePagedResult where T : BaseEntity
    {
        public ICollection<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}
