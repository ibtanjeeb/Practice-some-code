using System;

namespace RanDom1
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();

            var buffer = new char[10];

          for (var i = 0; i<10; i++)
            

                buffer[i] = (char)('a' + random.Next(0,26));
            var password = new string(buffer);

            Console.WriteLine(password);

            
        }
    }
}
