using SalesWeb.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesWeb.Tests.Entities.MockEntities
{
    public class MoqPagedResult : PagedResult<string> 
    {
        public MoqPagedResult(int currentPage, int pageSize, ICollection<string> results)
            : base(currentPage, pageSize, results) { }
    }
}
