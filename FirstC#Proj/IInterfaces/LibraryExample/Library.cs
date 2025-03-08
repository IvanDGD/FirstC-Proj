using System.Collections;

namespace FirstC_Proj.IInterfaces.LibraryExample
{
    internal class Library : IEnumerable
    {
        Book[] books =
        {
            new Book()
            {
                Title = "Відьмак: Останнє бажання",
                Author = new Author(){
                    FirstName = "Анджей",
                    LastName = "Сапковскій"
                },
                Pages = 300
            },
            new Book()
            {
                Title = "Гаррі Поттер і в'язниця Азкабану",
                Author = new Author(){
                    FirstName = "Джоан",
                    LastName = "Роулінг"
                },
                Pages = 391
            },
            new Book()
            {
                Title = "Маленький принц",
                Author = new Author(){
                    FirstName = "Антуан",
                    LastName = "Екзюпері"
                },
                Pages = 150
            }
        };

        public void Sort()
        {
            Array.Sort(books);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(books, comparer);
        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}

