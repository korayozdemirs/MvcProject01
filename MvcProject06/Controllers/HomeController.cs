using MvcProject06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject06.Controllers
{
    public class HomeController : Controller
    {
        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentID=1, StudentName="Steve", Age = 21 },
                    new Student(){ StudentID=2, StudentName="Bill", Age = 25 },
                    new Student(){ StudentID=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentID=4, StudentName="Ron", Age = 31 },
                    new Student(){ StudentID=5, StudentName="Rob", Age = 19 }
                };
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.TotalStudents = studentList.Count();
            ViewData["students"] = studentList;
            TempData["students"] = studentList.OrderByDescending(z => z.Age).Take(1).First().StudentName;
            return View();
        }
    }
}