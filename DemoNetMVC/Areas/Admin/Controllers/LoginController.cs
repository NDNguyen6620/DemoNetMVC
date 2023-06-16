using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoNetMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoNetMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/login")]

    public class LoginController : Controller
    {
        [Route("")]
        public IActionResult Index(Login login)
        {
            return View();
        }
    }
}