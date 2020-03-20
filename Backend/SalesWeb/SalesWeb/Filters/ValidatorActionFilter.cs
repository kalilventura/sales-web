using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SalesWeb.Domain.Handlers;
using System.Linq;

namespace SalesWeb.Filters
{
    public sealed class ValidatorActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.ModelState.IsValid)
            {
                var errors = filterContext.ModelState
                                .Values
                                .Where(v => v.Errors.Count > 0)
                                .SelectMany(v => v.Errors)
                                .Select(v => v.ErrorMessage);

                var result = new GenericResult(false, "One or more validation errors occurred.", errors);
                filterContext.Result = new BadRequestObjectResult(result);
            }
        }
    }
}
