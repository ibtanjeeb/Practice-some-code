using System.Collections.Generic;

namespace Lamdaexpression
{
    public class BookRapository
    {
        public List<Book>GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title= "Title1",Price =55},
                  new Book() {Title= "Title2",Price =20},
                    new Book() {Title= "Title3",Price =55}

            };
        }
    }
}
