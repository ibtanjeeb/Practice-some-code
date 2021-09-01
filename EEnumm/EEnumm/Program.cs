using System;

namespace EEnumm
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3

    }
    class Program
    {
        static void Main(string[] args)
        {

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;

            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            var shipningmethod =  (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shipningmethod);


        }
    }
}
