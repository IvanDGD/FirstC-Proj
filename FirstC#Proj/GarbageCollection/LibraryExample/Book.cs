using System;

namespace FirstC_Proj.GarbageCollection.Book
{
    internal class Book : IDisposable
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string YearOfRelease { get; set; }
        public int Pages { get; set; }

        public Book(string bookName, string author, string yearOfRelease, int pages)
        {
            BookName = bookName;
            Author = author;
            YearOfRelease = yearOfRelease;
            Pages = pages;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year of Manufacture: {YearOfRelease}");
            Console.WriteLine($"Pages: {Pages}");
        }

        ~Book()
        {
            Console.WriteLine("Finalizer called");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose method called");
            GC.SuppressFinalize(this);
        }
    }
}
