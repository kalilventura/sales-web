using SalesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Repositories
{
    public interface ISalesRecordRepository : IGenericRepository<SalesRecord>
    {
        Task<IEnumerable<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate);
        Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate);
    }
}
