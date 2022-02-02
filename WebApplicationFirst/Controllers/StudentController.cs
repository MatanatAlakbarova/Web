using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFirst.Models;

namespace WebApplicationFirst.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student> {
               new Student("Matanat",24,1),
               new Student("Efsane",42,2),
               new Student("Shebnem", 27, 3),
               new Student("Jale", 21, 4),
            };
            return View(students);
        }
    }
}
