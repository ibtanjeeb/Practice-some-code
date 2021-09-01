using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(((int)Days.Monday));
        }


        public enum Days
        {

            Monday =1,
            Sunday =2,
            Tuesday =3
        }
    }
}
