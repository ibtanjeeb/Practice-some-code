using System;

namespace Practice__14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopingCart cart = new ShopingCart();

            foreach(var i in cart)
            {

            }

            

            ShopingCart cart1 = (ShopingCart)cart.Clone();

            using ShopingCart cart3 = new ShopingCart();

        }
    }
}
