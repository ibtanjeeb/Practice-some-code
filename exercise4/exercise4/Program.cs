using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret number:" + number);

            

            for(var i = 0; i <4; i++)

            {

                Console.Write("guess the number");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won");
                    return;
                }

            }
            Console.WriteLine("you lost");

        }
    }
}
