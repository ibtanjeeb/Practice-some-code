using System;

namespace Csharpintermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Tanjeeb";
            Order order = new Order();

            //customer.Orders.Add(order);


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);



        }
    }
}
