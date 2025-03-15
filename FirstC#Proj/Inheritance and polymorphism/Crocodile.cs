using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Crocodile : Animal
    {
        public Crocodile(string name, string description) : base(name, description) { }

        public override void DoSound()
        {
            Console.WriteLine("Grrr!");
            Console.Beep(300, 500);
        }
    }
}
