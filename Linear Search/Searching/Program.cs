using System;

namespace Searching
{
    class Program
    {
        public static int Search(int[] arr, int x)
        {
            int n = arr.Length;
            for(var i=0; i<n;i++)
            {
                if (arr[i] == x)
                    return arr[i];
            }
            return -1;
        }
        static void Main(string[] args)
        {

            int[] arr = { 120, 154, 120, 112, 114, 55, 166 };
            int x = 112;
            int reuslt = Search(arr, x);
            if (reuslt == -1)

                Console.WriteLine("Elements is not Found");
            else
                Console.WriteLine("Your element is :" + reuslt);

        }
    }
}
