using System;
using CFundamental.Math;

namespace CFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tanjeeb = new Person();
            Tanjeeb.FirstName = "Tanjeeb";
            Tanjeeb.LastName = "Rahman";
            Tanjeeb.Introduce();
            Calculator calculator = new Calculator();

            var result = calculator.Add(10, 2);

            Console.WriteLine(result);

        }
    }
}
