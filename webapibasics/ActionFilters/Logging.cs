using Microsoft.AspNetCore.Mvc.Filters;

namespace webapibasics.ActionFilters;

public class Logging : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
       Console.WriteLine("Before call");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("After call");
    }
}