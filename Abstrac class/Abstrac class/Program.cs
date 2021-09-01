using System;

namespace Abstrac_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(100);

            Console.WriteLine("Area of Square is ={0}" ,sq.Area());

        }
    }
}
