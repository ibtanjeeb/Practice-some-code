using System;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's Name?");
            var name = Console.ReadLine();

            var t = ReverseName(name);
            Console.WriteLine("Reverse Name:" + t);

            

        }


        public static string ReverseName(string name)
        {
            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var t = new string(array);

            return t;

        }
    }
}
