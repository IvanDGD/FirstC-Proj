using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    //internal class Library<T> : IEnumerable<T> where T : Book
    //{
    //    private List<T> books = new List<T>();

    //    public void AddBook(T book)
    //    {
    //        books.Add(book);
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        foreach (var book in books)
    //        {
    //            yield return book;
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }

    //    public IEnumerable<T> SearchByGenre(string genre)
    //    {
    //        return books.Where(book => book.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
    //    }

    //    public IEnumerable<T> SearchByPublicationYear(int year)
    //    {
    //        return books.Where(book => book.PublicationYear == year);
    //    }
    //}
}
