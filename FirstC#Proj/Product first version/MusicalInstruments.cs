using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class MusicalInstruments
    {
        protected string Name;
        protected string Characteristics;

        public MusicalInstruments(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("This instrument makes a sound.");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Instrument: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Characteristics: {Characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine("This instrument has a rich history.");
        }
    }
}
