using Microsoft.AspNetCore.Diagnostics;
using ReadTrack.Contracts;
using ReadTrack.Entities;
using System.Net;

namespace ReadTrack.Api.Handlers;

public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILoggerManager _logger;

    public GlobalExceptionHandler(ILoggerManager logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        httpContext.Response.ContentType = "application/json";

        _logger.LogError($"Algo deu errado: {exception.Message}");

        await httpContext.Response.WriteAsync(new ErrorDetails()
        {
            StatusCode = httpContext.Response.StatusCode,
            Message = "Internal Server Error.",
        }.ToString());

        return true;
    }
}
