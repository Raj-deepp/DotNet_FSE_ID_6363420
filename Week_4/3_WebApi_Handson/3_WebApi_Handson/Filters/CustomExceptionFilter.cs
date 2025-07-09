using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var message = $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}";
        File.AppendAllText("errors.log", message);

        context.Result = new ObjectResult("An unexpected error occurred.")
        {
            StatusCode = 500
        };
    }
}
