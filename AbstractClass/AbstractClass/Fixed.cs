using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Fixed:Discount
    {
        public override int DiscountafterAmount(int TotalAmount)
        {
            return TotalAmount - DiscountAmount;
        }
    }
}
