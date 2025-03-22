using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class BookManager
    {
        private LinkedList<Book> books = new LinkedList<Book>();

        public void AddBook(Book book)
        {
            books.AddLast(book);
        }

        public void InsertBookAtBeginning(Book book)
        {
            books.AddFirst(book);
        }

        public void InsertBookAtEnd(Book book)
        {
            books.AddLast(book);
        }

        public void InsertBookAtPosition(Book book, int position)
        {
            if (position <= 0)
            {
                InsertBookAtBeginning(book);
                return;
            }

            int index = 0;
            LinkedListNode<Book> current = books.First;
            while (current != null && index < position - 1)
            {
                current = current.Next;
                index++;
            }

            if (current == null)
            {
                books.AddLast(book);
            }
            else
            {
                books.AddAfter(current, book);
            }
        }

        public void RemoveBook(string title)
        {
            LinkedListNode<Book> current = books.First;
            while (current != null)
            {
                if (current.Value.Title.ToLower() == title.ToLower())
                {
                    books.Remove(current);
                    Console.WriteLine($"Book '{title}' removed.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine($"Book '{title}' not found.");
        }

        public void RemoveBookFromBeginning()
        {
            if (books.First != null)
            {
                Console.WriteLine($"Book '{books.First.Value.Title}' removed from beginning.");
                books.RemoveFirst();
            }
        }

        public void RemoveBookFromEnd()
        {
            if (books.Last != null)
            {
                Console.WriteLine($"Book '{books.Last.Value.Title}' removed from end.");
                books.RemoveLast();
            }
        }

        public void RemoveBookAtPosition(int position)
        {
            if (position < 0 || books.Count == 0)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            int index = 0;
            LinkedListNode<Book> current = books.First;
            while (current != null)
            {
                if (index == position)
                {
                    books.Remove(current);
                    Console.WriteLine($"Book at position {position} removed.");
                    return;
                }
                current = current.Next;
                index++;
            }
            Console.WriteLine("Position out of range.");
        }

        public void UpdateBook(string oldTitle, Book updatedBook)
        {
            LinkedListNode<Book> current = books.First;
            while (current != null)
            {
                if (current.Value.Title.ToLower() == oldTitle.ToLower())
                {
                    current.Value = updatedBook;
                    Console.WriteLine($"Book '{oldTitle}' updated.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine($"Book '{oldTitle}' not found.");
        }

        public List<Book> SearchBooks(string searchTerm)
        {
            List<Book> result = new List<Book>();
            LinkedListNode<Book> current = books.First;
            while (current != null)
            {
                if (current.Value.Title.ToLower().Contains(searchTerm.ToLower()) ||
                    current.Value.Author.ToLower().Contains(searchTerm.ToLower()) ||
                    current.Value.Genre.ToLower().Contains(searchTerm.ToLower()) ||
                    current.Value.Year.ToString().Contains(searchTerm))
                {
                    result.Add(current.Value);
                }
                current = current.Next;
            }
            return result;
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
