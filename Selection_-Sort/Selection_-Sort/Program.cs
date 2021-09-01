using System;
using System.Collections.Generic;
namespace Selection__Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {56,2,8,3,10};
            int n = 5;
            Console.WriteLine(" the numbers:" );
            Console.Write("Initial Array is:");

           
            for (var i = 0; i < n; i++)
            {

                Console.WriteLine(arr[i] + " ");



            }
            int temp;
            int smallest;
            for(var i = 0;i<n-1;i++)
            {
                smallest = i;
                for(int j =i+1;j<n;i++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;

            }
            Console.WriteLine();
            Console.Write("Sorted array is:");
            for(var i =0;i<n;i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }
    }
}
