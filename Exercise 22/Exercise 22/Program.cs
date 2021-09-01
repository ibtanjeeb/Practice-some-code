using System;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while(true)
            {
                Console.Write("enter a number (or 'ok' to exit.):");
                var number = Console.ReadLine();

                if(number.ToLower() == "ok")
                {
                    break;

                    sum += Convert.ToInt32(number);

                }
                Console.WriteLine("Calculate the sum of all the previously entered numbers:" + sum);


            }
        }
    }
}
