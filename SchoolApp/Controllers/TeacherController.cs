using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult ShowTeacherName()
        {
            ViewBag.TeacherName = "Teacher one";
            return View();
        }

        public ActionResult ShowArrayOfTeachers()
        {
            string[] arrayOfTeachers = new string[] { "Teacher1" , "Teacher2" , "Teacher3", "Teacher4", "Teacher5", "Teacher6" }; 
            ViewBag.arrayOfTeac= arrayOfTeachers;
            return View();
        }


    }
}