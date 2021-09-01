using System;

using System.Collections.Generic;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = false;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1)
                {
                    isConsecutive = true;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);


        }
    }
}
