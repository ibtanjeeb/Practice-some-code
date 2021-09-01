using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            catch(Exception)
            {

                throw;
            }

            string number = "1234";
            byte b = Convert.ToByte(number);

            Console.WriteLine(b);
        }
    }
}
