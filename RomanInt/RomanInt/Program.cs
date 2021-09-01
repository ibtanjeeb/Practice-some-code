using System;

namespace RomanInt
{
    class Program
    {

        public static int Roman(string x)
        {
            char[] symbol = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] Values = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
            char[] input = new char[x.ToCharArray().Length]; 
            input = x.ToCharArray();

            int Result = 0;
            int PreIndex = 0;
            foreach(var i in input)
            {
                int index = Array.IndexOf(symbol, i);
                int value = Values[index];
                if (Result == 0)
                {
                    Result += value;

                }
                else
                {
                    if(Values[PreIndex]<value)
                    {
                        int ca = value-Values[PreIndex];
                        Result += ca;
                        Result -= Values[PreIndex];
                    }
                    else
                    {
                        Result += value;
                    }
                }
                PreIndex = index;

                
            }
            return Result;



        }
        static void Main(string[] args)
        {
            string x = "MCM";

            int Re = Roman(x);
            Console.WriteLine(Re);
        }
    }
}
