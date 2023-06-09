namespace HRManagementSystem.WebAPI.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            //request
            await _next(context);
            //response
        }
        catch (Exception ex)
        {
            await context.Response.WriteAsync(ex.Message);
        }
    }
}
