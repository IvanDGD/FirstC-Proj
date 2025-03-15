using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class ReadList
    {
        private List<Book> books = new List<Book>();

        public int Count => books.Count;

        public Book this[int index]
        {
            get => books[index];
            set => books[index] = value;
        }

        public void AddBook(Book book)
        {
            if (!books.Contains(book))
            {
                books.Add(book);
                Console.WriteLine($"Added: {book}");
            }
            else
            {
                Console.WriteLine("Book is already in the list.");
            }
        }

        public void RemoveBook(Book book)
        {
            if (books.Remove(book))
            {
                Console.WriteLine($"Removed: {book}");
            }
            else
            {
                Console.WriteLine("Book not found in the list.");
            }
        }

        public static ReadList operator +(ReadList list, Book book)
        {
            list.AddBook(book);
            return list;
        }

        public static ReadList operator -(ReadList list, Book book)
        {
            list.RemoveBook(book);
            return list;
        }


        public void ShowList()
        {
            Console.WriteLine("Reading List:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
