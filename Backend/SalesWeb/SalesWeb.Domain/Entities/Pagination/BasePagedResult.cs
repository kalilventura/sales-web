using System;

namespace SalesWeb.Domain.Entities.Pagination
{
    public abstract class BasePagedResult
    {
        protected BasePagedResult(int currentPage, int pageSize)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }

        public int FirstRowOnPage
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
        }

        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * PageSize, RowCount); }
        }

        public int PageCount
        {
            get { return (int)Math.Ceiling((double) RowCount / PageSize); }
        }
    }
}
