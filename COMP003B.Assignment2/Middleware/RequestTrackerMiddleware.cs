//Request Tracker Middleware

public class RequestTrackerMiddleware
{
    private readonly RequestDelegate _next;

    public RequestTrackerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

        await _next(context);

        Console.WriteLine($"Response Status: {context.Request.Method}");
    }
}
    
    
