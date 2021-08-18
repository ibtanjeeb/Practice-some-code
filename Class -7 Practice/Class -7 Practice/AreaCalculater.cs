using System;
using System.Collections.Generic;
using System.Text;

namespace Class__7_Practice
{
    public  class  AreaCalculater
    {
        public static int count;
        public static string Name { get; set; }
        public static double GetCircle(double radius )
        {
            return Math.PI * radius * radius;
        }
        public static double RecangleArea(double width,double Height)
        {
            return width * Height;
        }

        public void print ()
        {
            Console.WriteLine(Name);
        }
    }
}
