using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApp.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int YearOfBirth { get; set; }
        public int Class { get; set; }

    }
}