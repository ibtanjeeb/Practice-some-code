using System;
using System.Collections.Generic;
using System.Text;

namespace Class__7_Practice
{
    public class Student:Person
    {
        public readonly string studentId = "";
       

        private double cgpa;
        
       

        public double Cgpa

        { 
            get
            {
                return cgpa;
            }
        
        
                set
            {
                if (value > 0)
                    cgpa = value;
            }
         }

        public Student():this(string.Empty,DateTime.MinValue,"N/A")
        {
            


        }
        public Student(string name,DateTime dateofrbirth,string adress)
            : base("SD")
        {
            
            Name = name;
     
            DateofBirth = dateofrbirth;
            Address = adress;
            cgpa = 0;
           

           

        }
        public void Upadatedetails(string name)
        {
            Name = name;
        }
        public void Upadatedetails(DateTime datetime)
        {
            DateofBirth = datetime;
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
