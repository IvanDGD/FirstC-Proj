using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Kangaroo : Animal
    {
        public Kangaroo(string name, string description) : base(name, description) { }

        public override void DoSound()
        {
            Console.WriteLine("Thump!");
            Console.Beep(600, 500);
        }
    }
}
