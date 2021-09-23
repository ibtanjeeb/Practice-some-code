using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice__14_1
{
    public class ShopingCart : IEnumerable,ICloneable,IDisposable
    {
        public double TotalAmount { get; set; }
        public int ItemCount { get; set; }

        ArrayList items = new ArrayList();
        public void AddItem(object item)
        {
            items.Add(item);
            ItemCount++;

        }


        public void RemoveItem(object item)
        {
            items.Add(item);
            ItemCount--;

        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        

        public object Clone()
        {
            var newitem = new ShopingCart();

            newitem.ItemCount = ItemCount;
            newitem.TotalAmount = TotalAmount;

            return newitem;
        }

        public void Dispose()
        {
            items.Clear();
        }
    }
}
