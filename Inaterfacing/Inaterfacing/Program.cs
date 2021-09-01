using System;

namespace Inaterfacing
{
    class Program
    {
        static void Main(string[] args)
        {
            IColorable a = new Bottle();

            IClosable b = new Bottle();

            IContainer c = new Bottle();

            var colo = a.Color;

            //b.Open();
            c.AddContainer(2);

            c.RemoveConteiner(3);

            KitBox k = new KitBox();
            k.AddContainer(c);

            Bottle cb = new CorneredBottle();

            cb.Open();




        }
    }
}
