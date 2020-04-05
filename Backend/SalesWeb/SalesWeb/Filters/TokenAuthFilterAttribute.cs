using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace SalesWeb.Filters
{
    public sealed class TokenAuthFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
