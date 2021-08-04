using System;

namespace ReverseInt
{
    class Program
    {
        public static int Revers(int x)
        {
            long reverse = 0;
            int rem;
            while(x!=0)
            {
                rem = x % 10;
                reverse = reverse * 10 + rem;
                x /= 10;

            }
            try
            {
                string input = reverse.ToString();
                return int.Parse(input);
            }
            catch (Exception)
            {

                return 0;
            }

            
            



        }
        static void Main(string[] args)
        {
            int x = 1534236469;
            int result = Revers(x);
            Console.WriteLine(result);
        }
    }
}
