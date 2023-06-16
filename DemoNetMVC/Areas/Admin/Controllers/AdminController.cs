﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoNetMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : BaseController
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}