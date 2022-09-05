using Microsoft.AspNetCore.Mvc;
using mymvcproject.Models;
using System.Collections.Generic;

namespace mymvcproject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {

            List<Product>products=new List<Product>()
            {
                new Product { Id=1,Name="dell latop",Price=35000},
                 new Product { Id=2,Name="lenovo latop",Price=38000},
                  new Product { Id=3,Name="hp latop",Price=39000},
                   new Product { Id=4,Name="dell mouse",Price=340},
                    new Product { Id=5,Name="dell keyboard",Price=400},

            };
            ViewData["productlist"]=products;
            ViewBag.Products=products;
            return View();
        }
    }
}
