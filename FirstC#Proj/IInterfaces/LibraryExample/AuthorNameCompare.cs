using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.LibraryExample
{
    internal class AuthorNameCompare : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Book left && y is Book right)
            {
                return string.Compare(left.Author.FirstName, right.Author.FirstName);
            }
            throw new NotSupportedException("Using of unsupported type");
        }
    }
}
