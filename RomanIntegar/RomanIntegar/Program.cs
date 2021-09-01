using System;

namespace RomanIntegar
{
    class Program
    {
        public static int Romantoint(string s)
        {
            char[] Symbol = { 'I', 'V', 'X', 'L', 'C','D', 'M' };

            int[] Values = { 1, 5, 10, 50, 100, 500, 1000 };

            char[] input = new char[s.ToCharArray().Length];

            input = s.ToCharArray();

            var r = 0;
            var pre = 0;

            foreach(var i in input )
            {
                int index = Array.IndexOf(Symbol, i);

                int value = Values[index];

                if (r == 0)
                {
                    r += value;
                }
                else
                {
                    if (Values[pre] < value)
                    {
                        int ca = value - Values[pre];

                        r += ca;
                        r -= Values[pre];
                    }

                    else
                    {
                        r += value;
                    }

                }
                    pre = index;

                


            }
            return r;

            
}

        static void Main(string[] args)
        {
            string s = "MCM";

            int reult = Romantoint(s);
            Console.WriteLine(reult);
        }
    }
}
