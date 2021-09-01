using System;

namespace Jumpsearch1
{
    class Program
    {
        public static int Jump(int[]arr,int x)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while(arr[Math.Min(step,n)-1]<x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }
            if(arr[prev]<x)
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
            int[] arr = { 1, 1, 2, 3, 5, 44, 66, 77 };
            int x = 44;
            int index = Jump(arr, x);

            Console.WriteLine("Number" +x + "is at index" +index);

        }
    }
}
