using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Name()
        {
            ViewBag.Name = "Manager One";
            return View();
        }

        public ActionResult arrayOfNames()
        {
            string[] names = new string[] { "Manager1", "Manager2", "Manager3", "Manager4", "Manager5" };
            ViewBag.NamesArray = names;
            return View();
        }

        public ActionResult RandomNumbers()
        {
            int counter = 0;
            int[] randomNumArray = new int[10];
            Random random = new Random();

            while (counter < 10)
            {
                int randomNum = random.Next(1, 100);
                randomNumArray[counter] = randomNum;
                counter++;

            }


            ViewBag.arrayOfRandom = randomNumArray;
            return View();
        }

        public ActionResult LongerThen4()
        {

            string[] arrayOfLName = new string[] { "Tasama", "Tal", "Waise", "ttttt", "ppppp", "sssss", "sd", "lkk", "yalla", "Cohen" };
            ViewBag.arrayOfLName = arrayOfLName;

            return View();
        }



    }
}