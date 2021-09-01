using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
  public  class PercentageDiscount:Discount
    {

        public override int DiscountafterAmount(int TotalAmount)
        {
            return (int)((DiscountAmount / TotalAmount) * 100.0);
        }
    }
}
