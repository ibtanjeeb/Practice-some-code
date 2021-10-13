using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramwork.Entities
{
   public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Cgpa { get; set; }


    }
}
