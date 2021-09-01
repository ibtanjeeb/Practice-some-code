using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int count = 0;

            StreamReader file = new StreamReader (@"G:\MY FILES.txt");

            while((line = file.ReadLine()) != null)
            {
                string[] word = line.Split(' ');
                count += word.Length;


            }
            Console.WriteLine("Number of the word:" + count);
            //file.Close();





        }
    }
}            
