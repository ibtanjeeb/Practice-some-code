using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
   public class FixedAmount:Discount
    {
        public override int AmountAfterDiscount(int TotalAmount)
        {
            return TotalAmount - DiscountAmount;
        }

        

    }
}
