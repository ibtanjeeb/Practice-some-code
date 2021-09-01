using System;

namespace Accces_modfier
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;

        }
        public DateTime GetBirthDate()
        {

            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetBirthdate(new DateTime(2000, 2, 3));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
