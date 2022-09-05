using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mymvcproject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mymvcproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "this is sample mvc application";
            List<string> colorList = new List<string>()
            {
              "RED","GREEN","BLUE","YELLOW","BLACK","WHITE","PURPLE","PINK"
            };
            //ViewData["message"] = "This is my first page";
            //ViewData["Experience"] = "I have 1 year of experience";
            //ViewData["year"] = 2022;
            ViewData["list"] = colorList;

            ViewBag.ColorList = colorList;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult Contactus()
        {
            return View();
        }

    }
}
