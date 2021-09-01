using System;

namespace Stock
{
    public class ta
    {
        static int Totalstock(int[] stock, int buy, int sell)
        {
            if (sell <= buy)
                return 0;
            for (int i = buy;i < sell; i++)
            {
                for(int j = i+1; j <= sell;j++ )
                {

                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
