using System;

namespace Iterforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 100, 12, 100, 122 };
            
            foreach(var Number in number)
            {
                Console.WriteLine(Number);
            }

        }
    }
}
