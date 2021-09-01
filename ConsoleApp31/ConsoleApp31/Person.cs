using System;

namespace ConsoleApp31
{
    public class Person

    {

        public Person(DateTime birthdate)
        {

            BirthDate = birthdate;

        }

        public DateTime BirthDate { get;private set; }

        public int age
        {
            get 
            { 
                var timeSpan = DateTime.Today - BirthDate;

                var years = timeSpan.Days / 365;


                return years;

            }

            
        }





    }
}
