using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = (new Random()).Next(10);

            Console.WriteLine("Secret number is:" + number);

            for(var i = 0; i< 4;i++)
            {
                Console.Write("Guess The numner is :");
                var guess = Convert.ToInt32(Console.ReadLine());
                if(number == guess)
                {
                    Console.WriteLine("You won");

                    return;

                }
                Console.WriteLine("You Lost");
            }
        }
    }
}
