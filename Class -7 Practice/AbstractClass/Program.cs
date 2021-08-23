using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = GetDiscount();

            discount.DiscountAmount = 50;
            int amount = discount.AmountAfterDiscount(500);
            Console.WriteLine(amount);


        }

        public static Discount GetDiscount()
        {

            string userInput = Console.ReadLine();
            if (userInput == "Fixed")
                return new FixedAmount();
            else
                return new PercentageDiscount();

        }
    }
}
