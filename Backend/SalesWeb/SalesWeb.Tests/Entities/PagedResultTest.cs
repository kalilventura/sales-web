using SalesWeb.Tests.Entities.MockEntities;
using System.Collections.Generic;
using Xunit;

namespace SalesWeb.Tests.Entities
{

    public class PagedResultTest
    {
        [Fact]
        public void FirstRowOnPageTest()
        {
            var dataList = new List<string> { "A", "B", "C" };

            var pagedResult = new MoqPagedResult(1, 10, dataList);
            
            int firstRow = pagedResult.FirstRowOnPage;

            Assert.Equal(1, firstRow);
        }

        [Fact]
        public void RowCountTest()
        {
            var dataList = new List<string> { "A", "B", "C" };

            var pagedResult = new MoqPagedResult(1, 10, dataList);

            int lines = pagedResult.RowCount;

            Assert.Equal(3, lines);
        }

        [Fact]
        public void PageCountTest()
        {
            var dataList = new List<string> { "A", "B", "C" };

            var pagedResult = new MoqPagedResult(1, 10, dataList);

            int pages = pagedResult.PageCount;

            Assert.Equal(1, pages);
        }
    }
}
