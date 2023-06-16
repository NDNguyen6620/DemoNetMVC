using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace DemoNetMVC.Areas.Admin.Controllers
{
    public class BaseController : Controller,IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new RedirectToRouteResult(
                new RouteValueDictionary(new {Controller = "Login"})
            );
            //base.OnActionExecuting(context);
        }
    }
}