using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Trombone : MusicalInstruments
    {
        private string Type;
        private double Length;

        public Trombone(string name, string type, double length)
            : base(name, $"Type: {type}, Length: {length} cm")
        {
            Type = type;
            Length = length;
        }

        public override void Sound()
        {
            Console.WriteLine("The trombone produces a powerful and resonant sound.");
        }

        public override void Show()
        {
            Console.WriteLine($"Trombone: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Type: {Type}\nLength: {Length} cm\nThe trombone is a brass instrument with a sliding mechanism to change pitch.");
        }

        public override void History()
        {
            Console.WriteLine("The trombone originated in the 15th century and evolved from early slide trumpets.");
        }
    }
}
