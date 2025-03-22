using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int PublicationYear { get; }
        public string Genre { get; }

        public Book(string title, string author, int publicationYear, string genre)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Genre = genre;
        }
    }
}
