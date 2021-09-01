using System;

namespace Nullabletype
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine(date.GetValueOrDefault())
                ;
            Console.WriteLine(date.HasValue);
            Console.WriteLine(date.Value);
           // DateTime date1 = date ?? DateTime.Today;
            //Console.WriteLine(date1);
        }
    }
}
