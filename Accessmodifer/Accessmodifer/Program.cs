using System;

namespace Accessmodifer
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetBirthdate(new DateTime(2000, 1, 3));

            Console.WriteLine(person.GetBirthdate());
        }
    }
}
