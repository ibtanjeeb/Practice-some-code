using System;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            var  ar = new int[10];

            var j = 0;
            Console.Write(" Eneter the numbers of elements");

            Console.Write("\n--------------------------------\n");

            Console.Write("Inputs 10 elements in the Array:\n");
            for(var i=0; i<ar.Length;i++)
            {

                //Console.Write("Elements -{0}:", i);
                ar[i] = int.Parse(Console.ReadLine());
                j = ar[i];

                for (var n = 0; n <= j; n++)
                {
                    if (j % 2 == 0)

                        Console.WriteLine(n);
                }




            }








        }
    }
}
