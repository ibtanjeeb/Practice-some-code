using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while(true)
            {
                Console.Write("Enter a Number or 'ok' to exit):");
                var number = Console.ReadLine();

                if(number.ToLower() == "ok")
                
                    break;

                    sum += Convert.ToInt32(number);

                
                Console.WriteLine("Calculate the sum of previous number:" + sum);

            }
           
        }
    }
}
