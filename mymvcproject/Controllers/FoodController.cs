using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace mymvcproject.Controllers
{
    public class FoodController : Controller
    {
        [HttpGet]
        public IActionResult OrderFood()
        {
           
            List<string> options = new List<string>() { "Select option", "Yes", "No" };
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult OrderFood(IFormCollection form, ICollection<string> orders)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Contact = form["contact"];
            ViewBag.Payment = form["payment"];
            ViewBag.Orders = orders;
            ViewBag.Option = form["options"];
            return View("OrderDetails");



        }
    }
}
