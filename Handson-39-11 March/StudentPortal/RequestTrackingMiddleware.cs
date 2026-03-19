using StudentPortal.Models;
using System.Diagnostics;

namespace StudentPortal.Middleware
{
    public class RequestTrackingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTrackingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IRequestLogService logService)
        {
            var stopwatch = Stopwatch.StartNew();

            await _next(context);

            stopwatch.Stop();

            string log = $"URL: {context.Request.Path} | Time: {stopwatch.ElapsedMilliseconds} ms";

            logService.AddLog(log);
        }
    }
}