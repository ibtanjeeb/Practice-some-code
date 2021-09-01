using System;

namespace Data_Structure_Practice
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var arr = new array(length:2);

            arr.insert(item: 10);

            arr.insert(item: 20);
            arr.insert(item: 30);
            arr.insert(item: 10);

            arr.print();

            

          
        }
    }
}
