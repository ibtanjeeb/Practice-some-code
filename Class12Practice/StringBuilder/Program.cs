using System;
using System.Text;

namespace StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
           // string input = Console.ReadLine();

            //string newinpurt = input.Replace("A", "M");

            StringBuilder stringBuilder = new StringBuilder();

            while(true)
            {
                var word = Console.ReadLine();
                if (word == "exit")
                    break;
                else
                    stringBuilder.Append("<p>").Append(word).AppendLine("</p>");

                stringBuilder.Remove(0, 6);


            }

            Console.WriteLine(stringBuilder.ToString());


        }
    }
}
