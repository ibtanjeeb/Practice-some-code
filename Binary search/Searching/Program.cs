using System;

namespace Searching
{
    class Program
    {
        public static int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid =(r + l) / 2;


                if (arr[mid] == x)

                    return mid;


                if (arr[mid] > x)

                    return BinarySearch(arr, l, mid - 1, x);

                return BinarySearch(arr, mid + 1, r, x);

                


            }

            return -1;

        }
            


            
        static void Main(string[] args)
        {
            int[] arr = { 20, 35,36 , 39, 122,155 ,157,188};

            int n = arr.Length;

            int x = 36;

            int result = BinarySearch(arr, 0, n - 1, x);
            if (result == -1)


                Console.WriteLine("Not found");
            else
                Console.WriteLine("Your elements is :" + result);
        }
    }
}
