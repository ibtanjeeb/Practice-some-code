using System;

namespace Class_9_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = 5 - '0';

            Console.WriteLine(data);

            string a = "123456789123456789";
            int[] ar = new int[a.Length];

            for(int i= 0;i<a.Length;i++)
            {
                ar[i] = a[i] - '0';
                Console.Write(ar[i]);
            }
        }
    }
}
