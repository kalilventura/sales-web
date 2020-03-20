using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SalesWeb.Domain.Handlers;
using System;
using System.Threading.Tasks;

namespace SalesWeb.Middlewares
{
    /// <summary>
    /// Register Exception Middleware
    /// </summary>
    public static class ExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder builder) => builder.UseMiddleware<ExceptionHandlerMiddleware>();
    }

    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Unexpected error: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            var genericresult = new GenericResult(false, exception.Message, exception);

            var jsonResponse = JsonConvert.SerializeObject(genericresult);

            httpContext.Response.Clear();
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            return httpContext.Response.WriteAsync(jsonResponse);
        }

    }
}
