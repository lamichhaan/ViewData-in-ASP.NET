using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataExample.Models;

namespace ViewDataExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee() { EmpID = 101, EmpName = "Angat", EmpSalary = 3000000 };
            ViewData["myEmp"] = emp;
            return View();
        }
    }
}