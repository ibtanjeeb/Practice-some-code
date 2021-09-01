using System;

namespace Dt_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] ar = new int[n];
            int i;
            for (i = 0; i < n; i++)
                ar[i] = i + 1;



            for (i = 0; i < n; i++)
                Console.WriteLine(ar[i] + " ");
            Console.WriteLine();

            int x = 50;
            int pos = 5;
            int[] newarr = new int[n + 1];
            for (i = 0; i < newarr.Length; i++)
            {
                if (i < pos - 1)
                {
                    newarr[i] = ar[i];
                }
                else if (i == pos - 1)
                {
                    newarr[i] = x;
                }
                else
                {
                    newarr[i] = ar[i - 1];
                }

            }

            for (i = 0; i < newarr.Length; i++)
                Console.WriteLine(newarr[i] + " ");
            Console.WriteLine();






            //Console.WriteLine("Here is the Array List " +ar[i]);
        }
    }
}
