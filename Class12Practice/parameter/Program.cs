using System;

namespace parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum("hello",2,5,8,6);
            //Console.WriteLine(result);

            int x = 20;
            int y = 30;

            TestingparameterMod( ref x,ref y);

            Console.WriteLine($"x :{x} y:{y }");
            TestingParameterMod2(out x,out y);

            Console.WriteLine($"x :{x} y:{y }");

        }


        public static int Sum(string t, params int [] arr)
        {
            int sum = 0;
            

            foreach(var i in arr)
            {

                sum += i;
            }
            return sum;
        }


        static void TestingparameterMod(ref int a , ref int b)
        {
            a = 200;
            b = 78;

        }

        static void TestingParameterMod1(in int a , in int b)
        {

            
        }
        static void TestingParameterMod2(out int a, out int b)
        {
            a = 600;
            b = 21;

        }


    }
}
