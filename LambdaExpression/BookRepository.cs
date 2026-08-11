using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.LambdaExpression
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Title="Title 1", Price=5},
                new Book(){Title="Title 2",Price=7},
                new Book(){Title="Title 3",Price=15}
            };
        }
    }

    public class ProgrammBook
    {
        public void FindBooks()
        {
            var books = new BookRepository().GetBooks();
            var CheaperBooks = books.FindAll(book=>book.Price<10);

            //var CheaperBooks = books.FindAll(IsCheaperThank10Dollar);


            foreach (var book in CheaperBooks)
            {
                Console.WriteLine(book.Title);

            }
        }

        public bool IsCheaperThank10Dollar(Book book)
        {
            return book.Price < 10;
        }
    }
}
