using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Cello : MusicalInstruments
    {
        private string Size;
        private string BowMaterial;

        public Cello(string name, string size, string bowMaterial)
            : base(name, $"Size: {size}, Bow Material: {bowMaterial}")
        {
            Size = size;
            BowMaterial = bowMaterial;
        }

        public override void Sound()
        {
            Console.WriteLine("The cello produces a deep and warm sound.");
        }

        public override void Show()
        {
            Console.WriteLine($"Cello: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Size: {Size}\nBow Material: {BowMaterial}\nThe cello is a large string instrument known for its rich and warm tone.");
        }

        public override void History()
        {
            Console.WriteLine("The cello was developed in the 16th century as part of the violin family.");
        }
    }
}
