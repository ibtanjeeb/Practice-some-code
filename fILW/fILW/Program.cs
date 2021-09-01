using System;
using System.IO;
namespace fILW
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\somefiles.jpg";
            File.Copy(@"C:\temp\myfile.jpg", @"D:\temp\myfile.jpg", true);

            File.Delete(path);
            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileinfo = new FileInfo(path);

            fileinfo.CopyTo("...");

            fileinfo.Delete();
            if(fileinfo.Exists)
            {
                //
            }

        }
    }
}
