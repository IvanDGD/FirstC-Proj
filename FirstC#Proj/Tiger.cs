using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Tiger : Animal
    {
        public Tiger(string name, string description) : base(name, description) { }

        public override void DoSound()
        {
            Console.WriteLine("Roar!");
            Console.Beep(800, 500);
        }
    }
}
