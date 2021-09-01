using System;
using System.IO;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"F:\fl studio\FLEngine.dll";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension:" + Path.GetExtension(path));

            Console.WriteLine("Directory:" + Path.GetDirectoryName(path));
            Console.WriteLine("File Name :" + Path.GetFileName(path));
            Console.WriteLine("File Name without extension:" + Path.GetFileNameWithoutExtension(path));

        }
    }
}
