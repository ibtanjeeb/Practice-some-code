using System;

using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine(" enter a number or type 'Quit' to exit:" ,numbers);

                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));

            }
            var uni = GetUniqueNumbers(numbers);
            Console.WriteLine("Unique Number :");

            foreach(var num in uni)
            
                Console.WriteLine(num);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uni = new List<int>();

            foreach (var num in numbers)
            {
                if (!uni.Contains(num))

                    uni.Add(num);

               


            }
            return uni;
        }
    }
}
