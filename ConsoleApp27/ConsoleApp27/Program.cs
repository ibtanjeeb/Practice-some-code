using System;
using System.IO;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"G:\trans");

            //var files =Directory.GetFiles(@"G:\trans" ,"*jpg*", SearchOption.AllDirectories);

            //foreach (var file in files) 

            //Console.WriteLine(file);
            var directories = Directory.GetDirectories(@"G:\trans", "*.", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);
            Directory.Exists(@"G:\trans");

            var DirectoryInfo = new DirectoryInfo("...");
            DirectoryInfo.GetFiles();

            DirectoryInfo.GetDirectories();

            Console.WriteLine(DirectoryInfo);




        }
    }
}
