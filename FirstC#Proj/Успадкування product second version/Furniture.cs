using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Furniture : Product
    {
        public Furniture(string name, double price) : base(name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }
    }
}
