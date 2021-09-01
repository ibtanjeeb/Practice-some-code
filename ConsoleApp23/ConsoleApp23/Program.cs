using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a few words ");

            var input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("error");
                return;
            }

            var wpc = "";
            
            foreach(var word in input.Split(' '))
            {
                var wordwithpc = char.ToUpper(word[0]) + word.ToLower().Substring(1);

                wpc += wordwithpc;

            }
            Console.WriteLine(wpc);
        }
    }
}
