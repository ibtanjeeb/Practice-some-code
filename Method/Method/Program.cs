using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }
        static void UseParams()
        {
            Calculater calculater = new Calculater();

            Console.WriteLine(calculater.Add(1, 2));
            Console.WriteLine(calculater.Add(1, 2, 3));
            Console.WriteLine(calculater.Add(1, 2, 3));
            Console.WriteLine(calculater.Add(1, 2, 3, 4));
            Console.WriteLine(calculater.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void Usepoints()
        {

        
            try
            {
                var point = new Point(10, 20);

                point.Move((null));
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

                point.Move(new Point(1000, 650));
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

            }

            catch(Exception)

            {
                Console.WriteLine("Paikan is Going on");
            }
            


        }
    }
}
