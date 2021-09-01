using System;
using System.Collections.Generic;

namespace LList
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>() { 1, 2, 3, 4 };

            number.Add(1);

            number.AddRange(new int[5] { 5, 6, 7, 8, 9 });

            foreach (var n in number)

                Console.WriteLine(n);
            Console.WriteLine();

            Console.WriteLine("Index of Number 1 :" + number.IndexOf(1));
            Console.WriteLine("Index of Number 1 :" + number.LastIndexOf(1));

            Console.WriteLine("Count:" + number.Count);



            for (var i = 0; i<number.Count;i++)
            {
                if(number[i] == 1)
                number.Remove(number[i]);
            }

            foreach (var n in number)

                Console.WriteLine(n);

            number.Clear();

            Console.WriteLine("Count:" + number.Count);



        }
    }
}
