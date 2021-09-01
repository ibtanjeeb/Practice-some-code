using System;

namespace Exercise_2
{
    class Program
    {
        public static object ImageOrientation { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Image width:");
            int width = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Image Heigth:");
            int Heigth = Convert.ToInt32(Console.ReadLine());



            var Orientation = width >Heigth ? ImageOrientaion.Landscape : ImageOrientaion.Portrait;
            Console.WriteLine("Image Orientaion :" + Orientation);

            

        }
    }
}
