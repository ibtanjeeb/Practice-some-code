using System;

namespace ReplaceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            int[] ar = new int[] { 10, 20, 30, 50, 60 };

            int n = ar.Length;
            for (i = 0; i < n; i++)
                Console.Write( ar[i] + "  ");
            Console.WriteLine();
            int[] newArray = new int[] { 10, 20, 50, 60, 80 };

            

            for (i= 0;i<newArray.Length;i++)
            Console.Write(newArray[i] + "  ");
            Console.WriteLine();

            int[] final = new int[newArray.Length + n];

            int pos = final.Length;
            for (i=0;i<final.Length;i++)
            {
                if (i <= newArray.Length - 1)
                    final[i] = newArray[i];
                

               
                
                   
               
                
            }
            for (i = 0; i < final.Length; i++)
                Console.Write(final[i] + "  ");
            Console.WriteLine();
           


           

            //int[] newar1 = new int[n + newArray.Length];


          




               
            







        }

    }
}
