using FirstC_Proj.SOLID.IInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.SOLID
{
    internal class RectangleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Rectangle();
        }
    }
}
