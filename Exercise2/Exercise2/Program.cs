using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the number1:");

            int number1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the number2:");

            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number2);

            if(number1 > number2)
            {
                Console.WriteLine("number1 is Maximum");
            }
            else if(number1 == number2)
            {
                Console.WriteLine("number1 and number2 is equal");
            }
            else
            {
                Console.WriteLine("number2 is Maximum");
            }


        }
    }
}
