using Microsoft.AspNetCore.Mvc;
using mymvcproject.Models;
using System.Collections.Generic;


namespace mymvcproject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudList()
        {
            List<Student> students = new List<Student>()
            {
                new Student {Rollno =101,Name="rajesh",Percentage=85},
                 new Student { Rollno=102,Name="amol",Percentage=90},
                  new Student { Rollno=103,Name="tushar",Percentage=87},
                   new Student { Rollno=104,Name="ajay",Percentage=84},
                    new Student { Rollno=1055,Name="rahul",Percentage=92},

            };
            ViewData["studentlist"] = students;
            ViewBag.Students = students;
            return View();
        }
    }
}
