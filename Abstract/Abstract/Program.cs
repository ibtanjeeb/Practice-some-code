using System;

namespace Abstract
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var retangle = new Rectangle();
            retangle.Draw();


        }
    }
}
