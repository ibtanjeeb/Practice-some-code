using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int ExppnentialSearch(int[]arr,int n,int x)
        {
            if (arr[0] == x)
                return arr[0];

            int i = 1;
            while(i < n && arr[i] <= x)
            
                i = i * 2;


            
            return binarySearch(arr, i / 2, Math.Min(i, n - 1), x);



        }


        public static int binarySearch(int[] arr, int l,int r, int x)
        {
            if (r >= l)
            {
                int mid = l + r / 2;
                if (mid == x)
                    return mid;
                if (mid >x)
                    return binarySearch(arr, l, mid -1, x);
                
                    return binarySearch(arr, mid +1, r, x);
            }
            else
                return -1;


        }

        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 12, 13, 55, 66,88 ,99};
            int n = arr.Length;
            int x = 55;
            int reuslt = ExppnentialSearch(arr, n , x);
            if (reuslt == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Your elements is:" + reuslt);

        }
    }
}
