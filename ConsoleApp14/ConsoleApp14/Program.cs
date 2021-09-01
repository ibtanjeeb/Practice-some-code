using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating 
            var timespan = new TimeSpan(1, 2, 3);

            var timespan1 = new TimeSpan(1, 0, 0);

            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;

            var end = DateTime.Now.AddMinutes(2);

            var dura = end - start;

            Console.WriteLine("Duration:" + dura);


            //properties

            Console.WriteLine("Minutes:" + timespan.Minutes);

            Console.WriteLine("Total Minutes:" + timespan.TotalMinutes);


            Console.WriteLine("Add Example:" + timespan.Add(TimeSpan.FromMinutes(8)));

            Console.WriteLine("Add Example:" + timespan.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("To string:" + timespan.ToString());

            Console.WriteLine("parse:" + TimeSpan.Parse("01:02:00"));



        }
    }
}
