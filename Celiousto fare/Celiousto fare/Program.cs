using System;

namespace Celiousto_fare
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 clas = new Class1();

            string userinput = Console.ReadLine();
            double conin= double.Parse(userinput);

            Console.WriteLine(clas.Convert(conin));



        }


       
    }
}
