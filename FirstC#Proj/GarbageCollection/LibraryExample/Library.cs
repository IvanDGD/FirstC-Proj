using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GarbageCollection.Book
{
    internal class Library : IDisposable
    {
        private List<Book> books;
        private bool disposed = false;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.BookName} added to the library.");
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library is empty.");
                return;
            }

            Console.WriteLine("\nBooks in the Library:");
            foreach (var book in books)
            {
                book.DisplayInfo();
                Console.WriteLine("\n\n");
            }
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Disposing the library");
                books.Clear();
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~Library()
        {
            Dispose();
        }
    }
}
