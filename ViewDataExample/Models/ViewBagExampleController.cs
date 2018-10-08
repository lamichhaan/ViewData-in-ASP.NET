using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataExample.Models;

namespace ViewDataExample.Models
{
    public class ViewBagExampleController : Controller
    {
        // GET: ViewBagExample
        public ActionResult Index()
        {
            List<Employee> myEmpList = new List<Employee>();
            myEmpList.Add(new Employee() { EmpID = 100, EmpName = "Angat", EmpSalary = 20000000 });
            myEmpList.Add(new Employee() { EmpID = 101, EmpName = "John", EmpSalary = 20000 });
            myEmpList.Add(new Employee() { EmpID = 102, EmpName = "Amy", EmpSalary = 100000 });
            myEmpList.Add(new Employee() { EmpID = 103, EmpName = "Jody", EmpSalary = 40000 });
            ViewBag.listOfEmp = myEmpList;
            return View();
        }
    }
}