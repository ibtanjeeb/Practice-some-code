using System;

namespace Class_Practice
{
    class Program
    {
        #region method intro
        static void Main(string[] args)
        {
            int a = 10;
            int b = 9;

            int result = method(a, b);

            int c = 50;
            int d = 60;
            int result1 = method(c, d);



            Console.WriteLine(result);
            #endregion

            #region String method
            string adress = "Mirpur, Dhaka, Bangladesh.";


            Console.WriteLine("Contain Comma:" +adress.Contains(','));
            Console.WriteLine("Contain Ban:" + adress.Contains("Ban"));
            Console.WriteLine("contain H:" + adress.Contains('H', StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(adress.ToLower());
            Console.WriteLine(adress.ToUpper());
            Console.WriteLine("start with dh:"+adress.StartsWith("dh", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("End with sh:" + adress.EndsWith("sh"));
            int commaIndex = adress.IndexOf(',');
            commaIndex = adress.IndexOf(',', 7);
            Console.WriteLine("Comma Index:" + commaIndex);
            int indexany = adress.IndexOfAny(new char[] { ',', '.', '-', ':' });
            int indexany1 = adress.IndexOfAny(new char[] { ',', '.', '-', ':' },7,10);
            Console.WriteLine($"Index of any:{indexany},indecof any 2 {indexany1}");
            int pos = 0;
            while(pos >=0)
            {
                pos = adress.IndexOfAny(new char[] { ',', '.', '-', ':' },pos+1);

                if(pos>=-0)
                Console.WriteLine(pos);
            }

            Console.WriteLine(adress.LastIndexOf(','));

            Console.WriteLine(adress.LastIndexOfAny(new char[] { ',', '.', '-', ':' }));
            adress = adress.Insert(7,"--");
            Console.WriteLine(adress);
            adress = adress.PadRight(50,'*');
            Console.WriteLine(adress);
            adress = adress.PadLeft(70);
            Console.WriteLine(adress);

            adress = adress.Remove(30, 5);
            Console.WriteLine(adress);
            adress = adress.Replace('a', 'A');
            Console.WriteLine(adress);

            adress = "Mirpur, Dhaka,Bangladesh";
            string[] name = adress.Split(',');
            foreach(var item in name)
            Console.WriteLine(item.Trim());
            var trimepart1 = name[1].TrimStart();
            Console.WriteLine(trimepart1);

            adress = "*** Mirpur,dhaka,Bangladesh.***";

            adress= adress.Trim('*', ' ');
            Console.WriteLine(adress);
            adress = adress.Substring(10, 5);
            Console.WriteLine(adress);
            char[] address = adress.ToCharArray();
            string text1 = null;
            string text2 = "       ";
            var text =string.Empty;
            Console.WriteLine(string.Concat("Hello","world"));

            Console.WriteLine(string.IsNullOrEmpty(text));
            Console.WriteLine(string.IsNullOrEmpty(text1));
            Console.WriteLine(string.IsNullOrWhiteSpace(text2));
            Console.WriteLine(string.Join('+',name));

            #endregion

            #region char


            #endregion
        }


        static int method (int a, int b)
        {
            int reuslt = a * b + a * b;

            return reuslt;
        }
    }
}
