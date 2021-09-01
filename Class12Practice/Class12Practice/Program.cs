using System;

using System.Globalization;

namespace Class12Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateTime1 = new DateTime(2021, 8, 25);

            Console.WriteLine(DateTime1);

            DateTime DateTime2 = new DateTime(2021,8,26, 5, 25, 01);
            Console.WriteLine(DateTime2);


            DateTime Currenrtime = DateTime.Now;

            Console.WriteLine(Currenrtime);

            DateTime pasre = DateTime.Parse("8/26/2021");


            Console.WriteLine(pasre);


           // DateTime gg= DateTime.ParseExact("08/26/2021 12:00 AM","MM/dd/yyyy hh:mm:tt", CultureInfo.InvariantCulture);

            //Console.WriteLine(gg);
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.AddDays(22));
            Console.WriteLine(DateTime.Now.Month);

            Console.WriteLine(DateTime.Now.AddDays(-88));
            Console.WriteLine(DateTime.Now.AddYears(-5));

            Console.WriteLine(DateTime.UtcNow);

        }
    }
}
