using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's Name?");

            var Name = Console.ReadLine();

            char[] ar = Name.ToCharArray();

            Array.Reverse(ar);

            var re = new string(ar);

            Console.WriteLine();

            Console.WriteLine(re);


        }
    }
}
