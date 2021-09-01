using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();

            text.width = 100;
            text.copy();
            text.Duplicate();
        }
    }
}
