using System;

using System.Text;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            var Builder = new StringBuilder();

            Builder.Append('-',10);
            Builder.AppendLine();
            Builder.Append("Header");
            Builder.AppendLine();
            Builder.Append('-', 20);

            Builder.Replace('-', '+');
            Builder.Remove(0, 10);

            Console.WriteLine(Builder);

            

        }
    }
}
