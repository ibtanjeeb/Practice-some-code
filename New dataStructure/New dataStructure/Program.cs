using System;

namespace New_dataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] ar = new int[] { 10, 50, 6, 20, 50, 60, 90 };
            int n = ar.Length;
            for (i = 0; i < n; i++)


                Console.Write(ar[i]+"  ");
            Console.WriteLine();
            int[] newarray = new int[n + 1];
            int pos = 9;
            int x = 8;

            for(i=0;i<newarray.Length;i++)
            {
                if (i < pos)
                    newarray[i] = ar[i];

                else if (i == pos)
                    newarray[pos] = x;
                else
                    newarray[i] = ar[i - 1];




            }


            for(i=0;i<newarray.Length;i++)
                Console.Write(newarray[i]+"  ");
            Console.WriteLine();


            
        }
    }
}
