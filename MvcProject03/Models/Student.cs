using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject03.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public Gender StudentGender { get; set; }
    }

    public enum Gender
    {
        Disi,
        Erkek
    }
}