using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int[] myArr = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int i in myArr)
            {
                j = j + i;

                var n = j + 1;
                Console.WriteLine(n);
            }
        }
    }
}
