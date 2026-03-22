using Microsoft.AspNetCore.Mvc.Filters;

namespace StudentManagementSystem.Filters
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Action Executing: {context.ActionDescriptor.DisplayName}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action Executed at: {DateTime.Now}");
        }
    }
}