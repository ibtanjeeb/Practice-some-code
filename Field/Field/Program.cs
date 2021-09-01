using System;
namespace Field
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(0);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }

  
}
