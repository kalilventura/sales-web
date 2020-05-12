using System.Collections.Generic;

namespace SalesWeb.Domain.Entities.Pagination
{
    public class PagedResult<T> : BasePagedResult where T : class
    {
        public ICollection<T> Results { get; set; }

        public PagedResult(int currentPage, int pageSize, ICollection<T> results)
            : base(currentPage, pageSize)
        {
            //Results = new List<T>();
            Results = results;
            RowCount = Results.Count;
        }
    }
}
