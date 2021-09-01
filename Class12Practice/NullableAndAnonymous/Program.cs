using System;

namespace NullableAndAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {

            int? X = null;

            if(X== null)
                Console.WriteLine("X is null");

            if(X.HasValue)
                Console.WriteLine(X.Value);

            Print(X);


            static void   Print(int? Name)
            {
                dynamic item = new { name = "Tanjeeb", Age = 40, Location = "Chittagon" };

                Console.WriteLine(item.name +item.Age+item.Location);

            }

        }
    }
}
