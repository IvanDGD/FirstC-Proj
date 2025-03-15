using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Ukulele : MusicalInstruments
    {
        private string Size;
        private int Strings;

        public Ukulele(string name, string size, int strings)
            : base(name, $"Size: {size}, Strings: {strings}")
        {
            Size = size;
            Strings = strings;
        }

        public override void Sound()
        {
            Console.WriteLine("The ukulele produces a light and cheerful sound.");
        }

        public override void Show()
        {
            Console.WriteLine($"Ukulele: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Size: {Size}\nStrings: {Strings}\nThe ukulele is a small, guitar-like instrument known for its bright and joyful tone.");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele originated in Hawaii in the 19th century, influenced by Portuguese instruments.");
        }
    }
}
