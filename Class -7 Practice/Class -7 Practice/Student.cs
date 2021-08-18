using System;
using System.Collections.Generic;
using System.Text;

namespace Class__7_Practice
{
    class Student
    {

        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }

        private double cgpa;
        public string Address { get; set; }
        private readonly string studentId;

        public double Cgpa

        {
            get
            {
                return cgpa;
            }
        
        
                set
            {
                if (value >= 0)
                    cgpa = value;
            }
         }

        public Student():this(string.Empty,DateTime.MinValue,"N/A")
        {
            


        }
        public Student(string name,DateTime dateofrbirth,string adress)
        {
            Name = name;
     
            Dateofbirth = dateofrbirth;
            Address = adress;
            cgpa = 0;
            //studentId = name.ToLower().Substring(0, 2) + dateofrbirth.Year;

        }
        public void Upadatedetails(string name)
        {
            Name = name;
        }
        public void Upadatedetails(DateTime datetime)
        {
            Dateofbirth = datetime;
        }

        public void Upadatedetails(string name,string adress)
        {

        }
        public void Upadatedetails(string name, double cgpa)
        {

        }
        public void Upadatedetails( DateTime dateofbirth,string adress)
        {


        }


        public void Upadatedetails(string adress ,DateTime dateofbirth)
        {
           

        }







    }
}
