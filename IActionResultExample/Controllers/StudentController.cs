using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IActionResultExample.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is index view";
        }

        public string StudentName()
        {
            return "This is student view";
        }
    }
}
