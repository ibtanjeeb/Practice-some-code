using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsPrime(1);
            Console.WriteLine(result);
        }

        public static bool IsPrime(int number)
        {
            if(number <= 1)
            return false;

            
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }


    }
    
}
