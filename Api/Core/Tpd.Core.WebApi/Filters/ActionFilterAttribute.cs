using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Tpd.Core.WebApi.Filters
{
    public class ActionFilterAttribute : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.ModelState.IsValid)
            {
                var messages = filterContext.ModelState.Values.SelectMany(state => state.Errors)
                   .Select(s => s.ErrorMessage).ToList();

                var result = new JsonResult(new
                {
                    Success = false,
                    Message = messages
                });

                filterContext.Result = result;
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
