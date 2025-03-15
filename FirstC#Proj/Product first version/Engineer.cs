using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Engineer : Worker
    {
        public Engineer(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Engineer: {Name}\nDevelops, designs, and maintains technical solutions.");
        }
    }
}
