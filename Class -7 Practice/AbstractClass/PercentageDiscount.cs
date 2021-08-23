using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class PercentageDiscount:Discount
    {
        public override int AmountAfterDiscount(int TotalAmount)
        {
            return (int)(TotalAmount - (TotalAmount * DiscountAmount) / 100.0);
        }


    }
}
