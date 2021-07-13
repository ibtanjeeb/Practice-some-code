using System;

namespace Searching
{
   
    class Program
    {
        public static int jumpsearch(int[] arr, int x)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;

            }
            while (arr[prev] < x)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;

            }
            if (arr[prev] == x)
                return prev;
            return -1;


        }
        static void Main(string[] args)
        {
            int[] arr = { 22, 33, 55, 66, 1111, 444, 555, 22, 353, 15 };
            int x = 444;
            int index = jumpsearch(arr, x);




            Console.WriteLine("number"+x +" is at index"+index);
        }
    }
}
