using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.Serialize
{
    internal class Article
    {
        public string Title { get; set; }
        public int CharacterCount { get; set; }
        public string Preview { get; set; }

        public Article() { }

        public Article(string title, int characterCount, string preview)
        {
            Title = title;
            CharacterCount = characterCount;
            Preview = preview;
        }

        public override string ToString()
        {
            return $"- Назва: {Title}\n  Кількість символів: {CharacterCount}\n  Анонс: {Preview}\n";
        }
    }
}
