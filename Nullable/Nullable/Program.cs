using System;



namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value?" +number.HasValue);
            Console.WriteLine("Value " + number.GetValueOrDefault());

        }
    }
}
