using System;

namespace array_2d
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("Eneter the values{0} {1}:", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("Two Dimensional array Elements is:\n");

            for(int i =0;i<2; i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine(" " + arr[i,j]);
                    if(j==2)
                    {
                        Console.WriteLine("elements");
                    }
                }
            }
        }
    }
}
