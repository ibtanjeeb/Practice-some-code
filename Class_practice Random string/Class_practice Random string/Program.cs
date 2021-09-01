using System;

namespace Class_practice_Random_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Tanjeeb,Shortaj,Maxicanor ,Desktop,End of the day";

            Console.WriteLine(Name.Contains(','));
            Console.WriteLine(Name.ToLower());
            Console.WriteLine(Name.ToUpper());

            Console.WriteLine(Name.StartsWith("tAn", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(Name.EndsWith("day", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(Name.IndexOf("day"));
            int name = Name.IndexOfAny(new char[] { 'M', 'j' ,'d'});
               Console.WriteLine(name);

                






        }
    }
}
