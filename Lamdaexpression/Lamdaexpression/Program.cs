using System;

namespace Lamdaexpression
{
    class Program 
    {
        

        static void Main(string[] args)
        {
            var Books = new BookRapository().GetBooks();
            var cheapBooks = Books.FindAll(book =>book.Price<10);
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            
        }

        
    }
}
