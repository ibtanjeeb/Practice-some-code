using System;

namespace Practices
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[10];

            for (int i = 0; i <= arr.Length; i++)
            {
                n = i * 2;
                if(arr[n] ==0 || arr[n]==18)
                {
                    Console.WriteLine("Error " );
                }
                Console.WriteLine(n);


                
            }

            
        }
    }
}
