using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge 1. Write a program that reads a text file and displays the number of words.
            var path = @"G:\MY FILES.txt";

            var wordnum = new List<string>(File.ReadAllText(path).Split(' '));

            Console.WriteLine(wordnum.Count());

            int wordlength = 0;
            var longestword = "";

            foreach(var word in wordnum)
            {
                if (word.Length > wordlength)
                    longestword = word;
            }

            Console.WriteLine(longestword);

        }
    }
}
