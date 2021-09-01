using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>();

            while (num.Count <= 4)
            {
                Console.Write("Enter the number :");

                var input = Convert.ToInt32(Console.ReadLine());
                if (num.Contains(input))
                {
                    Console.WriteLine("Error And Retry again");

                    continue;
                }
                num.Add(input);

            }
                num.Sort();
                foreach(var n in num)
                {
                    Console.WriteLine(n);
                }
                    
                 


            
        }

    }
}

