using Lab2_WebAppASPNetMVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_WebAppASPNetMVC_Basics.Models;

namespace Lab2_WebAppASPNetMVC_Basics.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public actionresult index()
        //{
        //    return view();
        //}

        //public string Index()
        //{
        //    return "Welcome to ASP.Net MVC Programming.";
        //}

        //public string Index(int id)
        //{
        //    return "The value of id: " + id;
        //}

        //public string Index(int id, string name)
        //{
        //    return "The value of id: " + id + " and the value of name: " + name;
        //}

        public ActionResult Index()
        {
            List<Employee> listEmp = new List<Employee> {
             new Employee(){EmployeeId=1234,FirstName="Mary",LastName="Brown",Email="mary@yahoo.ca"},
             new Employee(){EmployeeId=1235,FirstName="John",LastName="Brown",Email="john@yahoo.ca"},
             new Employee(){EmployeeId=1236,FirstName="Marie",LastName="Tremblay",Email="marie@yahoo.com"},
             new Employee(){EmployeeId=1237,FirstName="Julia",LastName="Nguyen",Email="julia@gmail.com"},
             new Employee(){EmployeeId=1238,FirstName="Thomas",LastName="Moore",Email="jennifer@yahoo.ca"}
             };

            return View(listEmp);
        }

    }
}