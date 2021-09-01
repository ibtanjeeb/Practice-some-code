using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //(a) Integer
            int[] arrint = new int[5];
            Console.WriteLine("Please enter the integaer elements:");

            for (int i = 0; i < arrint.Length; i++)
            {
                arrint[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Print the integaer elements:");
            foreach (var elements in arrint)
            {
                Console.WriteLine(elements);
            }
            //(b) Double

            double[] arrDouble = new double[5];
            Console.WriteLine("Please enter the Double elements:");

            for (int i = 0; i < arrDouble.Length; i++)
            {
                arrDouble[i] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Print the Double elements:");
            foreach (var elements in arrDouble)
            {
                Console.WriteLine(elements);
            }
            //(c) Float
            float[] arrFloat = new float[5];
            Console.WriteLine("Please enter the Float elements:");

            for (int i = 0; i < arrFloat.Length; i++)
            {
                arrFloat[i] = float.Parse(Console.ReadLine());

            }
            Console.WriteLine("Print the Float  elements:");
            foreach (var elements in arrFloat)
            {
                Console.WriteLine(elements) ;
            }
            //(d) String
            string[] arrString = new string[5];
            Console.WriteLine("Please enter the Strings elements:");

            for (int i = 0; i < arrString.Length; i++)
            {
                arrString[i] = Console.ReadLine();

            }
            Console.WriteLine("Print the Strings elements:");
            foreach (var elements in arrString)
            {
                Console.WriteLine(elements);
            }
            //(e) DateTime
            DateTime[] arrdatetime = new DateTime[5];
            Console.WriteLine("Please enter the DateTime elements:");

            for (int i = 0; i < arrdatetime.Length; i++)
            {
                arrdatetime[i] =DateTime.Parse( Console.ReadLine());

            }
            Console.WriteLine("Print the DateTime elements:");
            foreach (var elements in arrdatetime)
            {
                Console.WriteLine(elements);
            }
            //(f) Decimal
            decimal[] arrDecimal = new decimal[5];
            Console.WriteLine("Please enter the Decimal elements:");

            for (int i = 0; i < arrDecimal.Length; i++)
            {
                arrDecimal[i] = decimal.Parse( Console.ReadLine());

            }
            Console.WriteLine("Print the Decimal elements:");
            foreach (var elements in arrDecimal)
            {
                Console.WriteLine(elements);
            }
            //(g) Long
            long[] arrLong = new long[5];
            Console.WriteLine("Please enter the Long elements:");

            for (int i = 0; i < arrLong.Length; i++)
            {
                arrLong[i] =long.Parse( Console.ReadLine());

            }
            Console.WriteLine("Print the Long elements:");
            foreach (var elements in arrLong)
            {
                Console.WriteLine(elements);
            }
            //(h) Bool
            bool[] arrBool = new bool[5];
            Console.WriteLine("Please enter the Bool elements:");

            for (int i = 0; i < arrBool.Length; i++)
            {
                arrBool[i] = bool.Parse(Console.ReadLine());

            }
            Console.WriteLine("Print the Bool elements:");
            foreach (var elements in arrBool)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
