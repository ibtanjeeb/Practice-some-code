using System;

namespace DateAnd_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime();

            var now = DateTime.Now;

            var today = DateTime.Today;

            Console.WriteLine("Hour:" + now.Hour);

            Console.WriteLine("Minutes:" + now.Minute);

            Console.Write("Date:" + today.Day);
            Console.Write("-" + today.Month);
            Console.WriteLine("-" + today.Year);

            var tommorow = now.AddDays(1);

            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("f"));
        }
    }
}
