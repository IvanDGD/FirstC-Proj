using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.File_System
{
    internal class Poem
    {
        public string poemName { get; set; }
        public string authorName { get; set; }
        public int yearOfWriting { get; set; }
        public string poemText { get; set; }
        public string poemTheme { get; set; }
        public Poem() { }
        public Poem(string name, string authorName, int year, string poemText, string poemTheme)
        {
            poemName = name;
            this.authorName = authorName;
            this.yearOfWriting = year;
            this.poemText = poemText;
            this.poemTheme = poemTheme;
        }

    }
}
