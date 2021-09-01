using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type your Name:");

                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {



                    Console.WriteLine("@echo :" + input);
                    continue;
                }
                break;





            }
        }
    }
}
