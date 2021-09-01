using System;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1= new Point();
            p1.X = 5;

            p1.Y = 2;

            Point p2 = p1;


            p2.X = 20;

            p2.Y = 30;

            Console.WriteLine($"X:{p1.X} ,Y:{p1.Y}");
            
            
        }
    }
}
