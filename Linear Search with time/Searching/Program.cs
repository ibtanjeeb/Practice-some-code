using System;

namespace Searching
{
  
    class Program
    {
        public static void search (int [] arr,int x)
        {
            int left = 0;
            int n = arr.Length;
            int right = n - 1;
            int position = -1;
            for(left=0; left<=right;)
            {
                if (arr[left] == x)
                {
                    position = left;



                        Console.WriteLine("Element is found" + (position + 1) + (left + 1));

                    break;

                }
                if(arr[right]==x)
                {
                    position = right;

                    Console.WriteLine("elment is found rihth" + (position + 1) + (n -right));
                    break;
                }

                left++;
                right--;

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
