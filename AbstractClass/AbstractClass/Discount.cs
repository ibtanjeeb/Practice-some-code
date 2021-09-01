using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Discount
    {

        public int DiscountAmount { get; set; }

        public abstract int DiscountafterAmount(int TotalAmount);
            

    }
}
