using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Violin : MusicalInstruments
    {
        private string Material;
        private int Strings;

        public Violin(string name, string material, int strings)
            : base(name, $"Material: {material}, Strings: {strings}")
        {
            Material = material;
            Strings = strings;
        }

        public override void Sound()
        {
            Console.WriteLine("The violin produces a rich and expressive sound.");
        }

        public override void Show()
        {
            Console.WriteLine($"Violin: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Material: {Material}\nStrings: {Strings}\nA violin is a string instrument known for its elegant tone and wide range of musical expression.");
        }

        public override void History()
        {
            Console.WriteLine("The violin originated in the early 16th century in Italy, evolving from medieval bowed instruments.");
        }
    }
}
