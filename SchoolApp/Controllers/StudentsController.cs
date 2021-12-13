using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Students()
        {
            Student studentOne = new Student() ;
            studentOne.FirstName = "Eden";
            studentOne.LastName = "Tasama";
            studentOne.YearOfBirth = 1996;
            ViewBag.Student = studentOne ;
            return View();
        }

       
    }
}