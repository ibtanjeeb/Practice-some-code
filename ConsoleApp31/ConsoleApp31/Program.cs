using System;

namespace ConsoleApp31
{

    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person(new DateTime(2000, 5, 6));

          
            Console.WriteLine(person.age);
        }
    }
}
