using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = GetDiscount();
            discount.DiscountAmount = 50;

           int amount= discount.DiscountafterAmount(5000);

            Console.WriteLine(amount);
        }


        public static Discount GetDiscount()
        {
            string UserInput = Console.ReadLine();
            if (UserInput == "Fixed")
                return new Fixed();
            else
                return new PercentageDiscount();



        }
    }
}
