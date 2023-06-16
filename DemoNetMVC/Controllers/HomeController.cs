using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoNetMVC.Models;

namespace DemoNetMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home", Name = "Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Shop", Name = "Shop")]
        public IActionResult Shop()
        {
            ViewData["Message"] = "Your Shop page.";

            return View();
        }

        [Route("ProductDetail",Name = "ProductDetail")]
        public IActionResult ProductDetail()
        {
            ViewData["Message"] = "Your application product detail.";

            return View();
        }

        [Route("MyOrder", Name = "MyOrder")]
        public IActionResult MyOder()
        {
            return View();
        }

        [Route("Checkout", Name = "Checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

        [Route("Contact", Name = "Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("MyFavorite", Name = "MyFavorite")]
        public IActionResult MyFavorite()
        {
            return View();
        }

        [Route("ShoppingCart", Name = "ShoppingCart")]
        public IActionResult ShoppingCart()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
