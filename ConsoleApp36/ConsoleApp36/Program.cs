using System;

namespace ConsoleApp36
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 2, 3, 5, 6 };
            arr[1] = new int[6] { 1, 2, 3, 4, 5, 6 };
            for(int i =0;i<arr.Length;i++)
            {
                Console.Write("Elements({0}): ", i);
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write("{0}{1}", arr[i][j], (j == arr[i].Length - 1 ) ? "" : " ");

                }
                Console.WriteLine();
            }



            Console.WriteLine("Press the key");
            Console.ReadKey();

        }
    }
}
