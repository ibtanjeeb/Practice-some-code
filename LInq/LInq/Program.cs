using System;
using System.Linq;
using System.Collections.Generic;

namespace LInq
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookRapository().GetBooks();

            var cheapbook = book
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Tilte)
                                .Select(b=>b.Tilte);


            foreach (var boo in cheapbook)

                Console.WriteLine(boo);
               // Console.WriteLine(boo.Tilte + " " + boo.Price);
        }
    }
}
