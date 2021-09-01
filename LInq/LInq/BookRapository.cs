using System.Collections.Generic;

namespace LInq
{
    public class BookRapository
    {
        public IEnumerable<Book> GetBooks()

        {

            return new List<Book>
            {
                new Book()  {Tilte= "bDO.NET step by step", Price = 5 },
                 new Book()  {Tilte= "ASP.NET MVC", Price = 5.5f },
                  new Book()  {Tilte= "ASP.NET API", Price = 6088 },
                   new Book()  {Tilte= "C# Advance Topics", Price = 66.55f },
                    new Book()  {Tilte= "ADO.NET", Price = 60.5f }

            };
        }

    }
}
