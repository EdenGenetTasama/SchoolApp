using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentName()
        {
            ViewBag.StudentName = "Avi "; 
            return View();
        }

        public ActionResult ShowStudentInfo()
        {
            
            return View();
        }

        public ActionResult StudentsAllName()
        {
            string[] arrayOfStudents = new string[] { "StudentOne", "StudentTwo", "StudentThree", "StudentFour", "StudentFive", "StudentSix" };
            ViewBag.arrayOfNames = arrayOfStudents;
            return View();

        }

        public ActionResult ShowAllStudent()
        {
            return View();
        }

        public ActionResult JsonReturn()
        {
            string[] arrayOfStudents = new string[] { "StudentOne", "StudentTwo", "StudentThree", "StudentFour", "StudentFive", "StudentSix" };
            //ViewBag.arrayOfNames = arrayOfStudents;
            return Json(arrayOfStudents , JsonRequestBehavior.AllowGet);
        }
    }
}