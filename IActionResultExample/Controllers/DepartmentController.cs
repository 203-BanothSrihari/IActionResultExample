using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IActionResultExample.Models;

namespace IActionResultExample.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> department = new List<Department>();

            department.Add(new Department() { DeptID = 567, DeptName = "Srihari", DeptLoc = "HYD" });

            department.Add(new Department() { DeptID = 345, DeptName = "Srikanth", DeptLoc = "KMM" });

            department.Add(new Department() { DeptID = 852, DeptName = "Venkatesh", DeptLoc = "SRPT" });

            department.Add(new Department() { DeptID = 963, DeptName = "Rajiv", DeptLoc = "NLG" });

            ViewData["department"] = department;

            return View();
        }
    }
}
