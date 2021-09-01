using System;
using System.Collections.Generic;
using System.Text;

namespace Inaterfacing
{
    public class Bottle : IContainer, IColorable, IClosable
    {
        public double Capacity { get ; set ; }
        public string Color { get ; set ; }

        double ConteinAmount { get; set; }
        public bool Isopen;


        public void AddContainer(double Amount)
        {
            ConteinAmount += Amount;
        }

        public void Close()
        {
            Isopen = false;
        }

        public void Open()
        {
            Isopen = true;

            Console.WriteLine("Open from Bottle");
        }

        public void RemoveConteiner(double Amount)
        {
            ConteinAmount -= Amount;
        }
    }
}
