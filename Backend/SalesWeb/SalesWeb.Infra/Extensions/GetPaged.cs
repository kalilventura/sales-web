using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Entities.Pagination;
using System;
using System.Linq;

namespace SalesWeb.Infra.Extensions
{
    public static class Pagination
    {
        public static PagedResult<T> GetPaged<T>(this IQueryable<T> query, int page, int pageSize) where T : BaseEntity
        {
            //var result = new PagedResult<T>
            //{
            //    CurrentPage = page,
            //    PageSize = pageSize,
            //    RowCount = query.Count()
            //};

            //var pageCount = (double)result.RowCount / pageSize;
            //result.PageCount = (int)Math.Ceiling(pageCount);


            var skip = (page - 1) * pageSize;
            var queryResults = query.Skip(skip).Take(pageSize).ToList();

            var result = new PagedResult<T>(page, pageSize, queryResults);

            return result;
        }
    }
}
