using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstC_Proj.SOLID.IInterface;

namespace FirstC_Proj.SOLID
{
    abstract class ShapeFactory
    {
        public abstract IShape CreateShape();
    }
}
