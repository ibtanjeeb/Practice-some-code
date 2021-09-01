using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                Console.Write("Type your Name:");

                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;

                }
                    Console.WriteLine("@echo :" + input);
                    
                
                

            }
        }
    }
}
