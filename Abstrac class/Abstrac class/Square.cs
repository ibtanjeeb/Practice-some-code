using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrac_class
{
  public  class Square:ShapeClass
    {
        int side = 0;

        public Square(int n)
        {
            side = n;

        }

        public override int Area()
        {
            return side * side;
        }
    }
}
