using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var http = new HttpCookie();

            http["name"] = "Tanjeeb";
            Console.WriteLine(http["name"]);
        }
    }
}
