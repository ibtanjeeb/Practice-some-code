using System;

namespace Arrayyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 2, 6, 3, 5, 10, 5 };




            //length
            Console.WriteLine("Array length is:" + number.Length);


            // Indexof()

            var index = Array.IndexOf(number, 5);

            Console.WriteLine("Inder number is:"+index);

            //clear Method()

            Array.Clear(number, 3, 2);

            Console.WriteLine("Effect to clear ()");


            foreach(var n in number)
            {
                Console.WriteLine(n);
            }
            //copy ()
            int[] another = new int[5];

            Array.Copy(number, another, 5);

            Console.WriteLine("effect to copy()");

            foreach(var n in another)
            {
                Console.WriteLine(n);
            }
            //sort()

            Array.Sort(number);

            Console.WriteLine("Sorted element:");
            foreach(var n in number)
            {
                Console.WriteLine(n);
            }

            //reverse()

            Array.Reverse(number);
            Console.WriteLine("Reverse is here:");
            foreach(var n in number)
            {
                Console.WriteLine(n);
            }









        }
    }
}
