using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a time value:");
            var inpur = Console.ReadLine();

            
        }

        public bool IsValidTime(string inpur )
        {
            if (string.IsNullOrWhiteSpace(inpur))
            {
                
                return false;
            }

            var component = inpur.Split(':');

            if (component.Length != 2)

            {
                
                return false;

            }
            try
            {
                var Hour = Convert.ToInt32(component[0]);

                var minutes = Convert.ToInt32(component[1]);


                return (Hour >= 0 && Hour <= 23 && minutes >= 0 && minutes <= 59);
                    

              

            }

            catch (Exception)
            {
                return false;

            }
        }
    }
}