using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string address = "Mirpur, Dhaka,Bangladesh.";

            Console.WriteLine("Contains k: " + address.Contains('k'));

            Console.WriteLine(address.ToLower());
            Console.WriteLine(address.ToUpper());

            Console.WriteLine(address.StartsWith('d'));
            Console.WriteLine("End With SH: " + address.EndsWith("SH", StringComparison.OrdinalIgnoreCase));

            int commaIndex = address.IndexOf(',');
            commaIndex = address.IndexOf(',', 7);
            Console.WriteLine("Comma Index: " + commaIndex);

            int indexOfAny = address.IndexOfAny(new char[] { ',', '.', ';' });
            int indexOfAny2 = address.IndexOfAny(new char[] { ',', '.', ';' }, 7, 10);

            Console.WriteLine($"IndexOfAny: {indexOfAny}, IndexOfAny 2: {indexOfAny2} ");

            int pos = 0;
            while (pos >= 0)
            {
                pos = address.IndexOfAny(new char[] { ',', '.', ';' },pos+1 );
                if (pos >= 0)
                    Console.WriteLine(pos);
            }
        }
    }
}
