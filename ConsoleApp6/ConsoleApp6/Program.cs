using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            var number = Convert.ToInt32(Console.ReadLine());

            var f = 1;
            for(var i =number; i>=1; i--)
            {
                f *= i;
            }

            Console.WriteLine("{0}!={1}", number, f);



        }
    }
}
