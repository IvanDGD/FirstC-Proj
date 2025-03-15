using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Device
    {
        protected string Name;
        protected string Characteristics;

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Generic device sound");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Device: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Characteristics: {Characteristics}");
        }
    }
}
