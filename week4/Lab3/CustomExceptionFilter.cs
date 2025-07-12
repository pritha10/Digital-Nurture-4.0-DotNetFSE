using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace YourNamespace.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exceptionMessage = context.Exception.ToString();
            File.AppendAllText("exceptions.txt", $"{DateTime.Now}: {exceptionMessage}{Environment.NewLine}");

            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
