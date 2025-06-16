using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class TokenAuthenticationMiddleware
{
    private readonly RequestDelegate _next;
    private const string AUTH_HEADER = "Authorization";
    private const string BEARER_PREFIX = "Bearer ";
    private const string VALID_TOKEN = "your-secret-token"; // Replace with your real token logic

    public TokenAuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Path.StartsWithSegments("/swagger"))
        {
            await _next(context);
            return;
        }

        if (!context.Request.Headers.ContainsKey(AUTH_HEADER) ||
            !context.Request.Headers[AUTH_HEADER].ToString().StartsWith(BEARER_PREFIX) ||
            context.Request.Headers[AUTH_HEADER].ToString().Substring(BEARER_PREFIX.Length) != VALID_TOKEN)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync(new { error = "Unauthorized" });
            return;
        }

        await _next(context);
    }
}