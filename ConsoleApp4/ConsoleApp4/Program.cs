using System;

namespace ConsoleApp4
{
}
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok to exit) :");

                var input = Console.ReadLine();


                if (input.ToLower() == "ok")
                {
                    break;
                    sum += Convert.ToInt32(input);

                }
                Console.WriteLine("Calculate the all number of sum :" + Sum);




            }
        }
    }

