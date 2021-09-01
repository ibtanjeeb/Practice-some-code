using System;

using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be really really really really really long text.";

            const int maxlength = 20;
            if (sentence.Length < maxlength)

                Console.WriteLine(sentence);



            else
            {
                var word = sentence.Split(' ');
                var totalchar = 0;
                var summword = new List<string>();


                foreach (var i in word)
                {
                    summword.Add(i);
                    totalchar += i.Length + 1;
                    if (totalchar > maxlength)
                        break;


                }

                var summary = String.Join(" ", summword) + "...";

                Console.WriteLine(summary);

            }
        }
    }
}
