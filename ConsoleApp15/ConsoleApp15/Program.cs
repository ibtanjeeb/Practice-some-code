using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Tanjeeb Rahman ";

            Console.WriteLine("Trim: '{0}'" ,fullname.Trim());


            Console.WriteLine("To Upper: '{0}'", fullname.Trim().ToUpper());

            var index = fullname.IndexOf(' ');

            var FristName = fullname.Substring(0, index);

            var LastName = fullname.Substring(index + 1);

            Console.WriteLine("Frist Name :" + FristName.ToUpper());

            Console.WriteLine("Last Name : " + LastName.ToUpper());

            var Names = fullname.Split(' ');

            Console.WriteLine("Frist Name :" + Names[0].ToLower());

            Console.WriteLine("Last Name :" + Names[1].ToLower());

            Console.WriteLine( fullname.Replace("Tanjeeb","Babu"));
            var str = "26";

            var age =Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 25.50f;

            

            Console.WriteLine(price.ToString("C"));

        }
    }
}
