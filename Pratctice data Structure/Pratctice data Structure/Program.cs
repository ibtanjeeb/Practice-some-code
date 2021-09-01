using System;

namespace Pratctice_data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {00  };

            int[] arr1 = new int[] { 50, 30, 80, 90 };

            int[] arr3 = new int[arr1.Length + arr.Length];
            int j = 0;

            for(int i =0;i< arr3.Length;i++)
            {
                if (i < arr1.Length)
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    arr3[i] = arr[j];
                    j++;
                }


            }
            for (int k = 0; k < arr3.Length; k++) 
            Console.WriteLine(arr3[k]);
        }
    }
}
