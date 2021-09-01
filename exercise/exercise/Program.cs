using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(speedLimit);

            Console.WriteLine("enter the speed of a Car");
            int speedofCar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(speedofCar);
            if (speedofCar < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int perKmhour = 5;

                var demeritpoint = (speedofCar-speedLimit) / perKmhour;

                Console.WriteLine("Calculate the demerit Point:" + demeritpoint);

              if(demeritpoint>12)
                {
                    Console.WriteLine("License suspened");
                }
                else
                {
                    Console.WriteLine("Demerit Point:"+demeritpoint);
                }

            }
            



        }
    }
}
