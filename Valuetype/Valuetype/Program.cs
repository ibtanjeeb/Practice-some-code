using System;

namespace Valuetype
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;

            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1} ", a, b));

            var array1 = new int[3] { 5,6,7};

            var array2 = array1;

            

            Console.WriteLine(("array1[0] : {0}, array2[0] : {1}"), array1[0], array2[0]);
        }
    }
}
