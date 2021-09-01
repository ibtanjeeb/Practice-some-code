﻿using System;
namespace MethodOverriding
{
    public class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
       
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a retangle");

        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public Position Position { get; set; }
        public virtual void Draw()
        {

        }
        
    }
}
