using System;

namespace Inheritence
{
    public class PresentaionObject
    {
        public int width { get; set; }
        public int heigth { get; set; }
        public void copy()
        {
            Console.WriteLine("Obkect was Copied to clipboard ");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }

    }
}
