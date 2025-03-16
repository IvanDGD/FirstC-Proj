using System;

namespace FirstC_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //GarbageCollection.Book.Book book1 = new GarbageCollection.Book.Book("1984", "George Orwell", "1949", 328);
            //book1.DisplayInfo();

            //book1.Dispose();

            //GarbageCollection.Book.Book book2 = new GarbageCollection.Book.Book("To Kill a Mockingbird", "Harper Lee", "1960", 281);
            //book2.DisplayInfo();

            //book2 = null;
            //GC.Collect();
            #endregion
            #region Task2
            //GarbageCollection.Book.Library myLibrary = new GarbageCollection.Book.Library();

            //myLibrary.AddBook(new GarbageCollection.Book.Book("1984", "George Orwell", "1949", 328));
            //myLibrary.AddBook(new GarbageCollection.Book.Book("To Kill a Mockingbird", "Harper Lee", "1960", 281));
            //myLibrary.DisplayBooks();

            //myLibrary.Dispose();

            //GarbageCollection.Book.Library anotherLibrary = new GarbageCollection.Book.Library();
            //anotherLibrary.AddBook(new GarbageCollection.Book.Book("Brave New World", "Aldous Huxley", "1932", 288));
            //anotherLibrary.DisplayBooks();

            //anotherLibrary.Dispose();
            //anotherLibrary = null;
            //GC.Collect();
            #endregion
            #region Task3
            //GarbageCollection.LibraryExample.File myFile = null;

            //try
            //{
            //    myFile = new GarbageCollection.LibraryExample.File("document.txt", 2048, "C:\\Files\\document.txt");
            //    myFile.DisplayInfo();
            //}
            //finally
            //{
            //    if (myFile != null)
            //    {
            //        myFile.Dispose();
            //    }
            //};
            //GarbageCollection.LibraryExample.File anotherFile = new GarbageCollection.LibraryExample.File("image.jpg", 500000, "C:\\Images\\image.jpg");

            //anotherFile = null; 
            //GC.Collect();
            #endregion
        }
    }
}