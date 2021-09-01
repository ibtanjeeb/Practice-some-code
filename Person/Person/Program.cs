using System;
using System.Runtime.InteropServices;

namespace Person
{
    public class Person
    {
        

        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "TAJ";

            person.Introduce();
        }

        public string Name;

        public void Introduce()
        {
            Console.WriteLine("HI, My Name is " + Name);

        }

    }
}
