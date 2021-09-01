using System;
using System.Linq;
namespace Extensionmethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "hasda ajsdjkalsjdas asdjasda asdjajda asjdajha asdjadalkdalda ajs ajajdakda....";

            var shortenpost = post.Shorten(1);
            Console.WriteLine(shortenpost);

        }
    }
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberofwords)
        {
            if (numberofwords < 0)
                throw new ArgumentException("Number shoud be.....");

            if (numberofwords == 0)
                return "0 word";
            var word = str.Split(' ');
            if (word.Length <= numberofwords)
                return str;
            return string.Join(" ", word.Take(numberofwords));

        }
    }
}
