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

            Assert.Equal(1, pagedResult.FirstRowOnPage);
        }

        [Fact]
        public void RowCountTest()
        {
            var dataList = new List<string> { "A", "B", "C" };
            var pagedResult = new MoqPagedResult(1, 10, dataList);

            Assert.Equal(3, pagedResult.RowCount);
        }

        [Fact]
        public void PageCountTest()
        {
            var dataList = new List<string> { "A", "B", "C" };
            var pagedResult = new MoqPagedResult(1, 10, dataList);

            Assert.Equal(1, pagedResult.PageCount);
        }
    }
}
