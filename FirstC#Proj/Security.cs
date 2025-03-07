using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Security : Worker
    {
        public Security(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Security: {Name}\nEnsures safety and security of the company.");
        }
    }
}
