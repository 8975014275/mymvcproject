using Microsoft.AspNetCore.Mvc;
using mymvcproject.Models;
using System.Collections.Generic;


namespace mymvcproject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id=101,Name="rajesh",Salary=35000},
                 new Employee { Id=102,Name="amol",Salary=38000},
                  new Employee { Id=103,Name="tushar",Salary=39000},
                   new Employee { Id=104,Name="ajay",Salary=40000},
                    new Employee { Id=1055,Name="rahul",Salary=20000},

            };
            ViewData["employeelist"] = employees;
            ViewBag.Employees = employees;
            return View();
        }
    }
}
