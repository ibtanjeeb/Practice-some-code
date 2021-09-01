using System;

namespace Prefix
{
    class Program
    {
        public static string Prefix(string[] arr)
        {
            //int t = 0;
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }


        }
        static void Main(string[] args)
        {
            string[] pre = new string[] { "flower", "flow", "flight" };
       

            Console.WriteLine(Prefix(pre));
        }
    }
}
