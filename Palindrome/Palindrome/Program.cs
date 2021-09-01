using System;

namespace Palindrome
{
    class Program
    {
        public static bool palindrome(int x)
        {
            int sum = 0;
            int temp,r;
            temp = x;
            while(x>0)
            {
                r = x % 10;
                sum = (sum * 10) + r;
                x /= 10;

            }
            if (temp == sum)
                return true;
            else
                return false;

           





        }
        static void Main(string[] args)
        {
            int x = -121;
            bool result = palindrome(x);
            Console.WriteLine(result);
        }
    }
}
