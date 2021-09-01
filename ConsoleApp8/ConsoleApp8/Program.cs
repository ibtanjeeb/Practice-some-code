using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Console.Write("Enter series of the number:" );

                var input = Console.ReadLine();

                var numbers = input.Split(',');

                var max = Convert.ToInt32(numbers[0]);

            var min = Convert.ToInt32(numbers[0]);
                
            foreach(var i in numbers)
            {
                var number = Convert.ToInt32(i);

                if (number > max)
                    max = number;
                if (number < min)
                    min = number;

            }

            Console.WriteLine("Max is :" + max);

            Console.WriteLine("Min is:" + min);
                



            
        }
    }
}
