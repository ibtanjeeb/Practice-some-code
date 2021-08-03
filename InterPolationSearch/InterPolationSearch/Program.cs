using System;

namespace InterPolationSearch
{
    class Program
    {
        public static int Interpolationsearch(int[] arr, int lo,int hi, int x)
        {
            int pos;
            if (lo <= hi && x>= arr[lo]&& x<= arr[hi])
            {
                pos = lo + (((hi - lo) /(arr[hi] - arr[lo])) *(x - arr[lo]));
                if (arr[pos] == x)
                    return pos;
                if (arr[pos] < x)
                    return Interpolationsearch(arr, pos + 1, hi, x);
                if (arr[pos] > x)
                    return Interpolationsearch(arr, lo, pos - 1, x);
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 6, 8, 10, 13 };
            int n = arr.Length;
            int x = 13;
            int result = Interpolationsearch(arr, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Your index is " + result);
        }
    }
}
