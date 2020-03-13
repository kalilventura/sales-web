using SalesWeb.Domain.Handlers.Interfaces;

namespace SalesWeb.Domain.Handlers
{
    public class GenericResult : IGenericResult
    {
        public GenericResult() { }

        public GenericResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public GenericResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public GenericResult(bool success, object data)
        {
            Success = success;
            Data = data;
        }

        public bool Success { get; }
        public string Message { get; }
        public object Data { get; }
    }
}
