using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    abstract class GeometricFigure
    {
        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Area: {Area():F2}");
            sb.AppendLine($"Perimeter: {Perimeter():F2}");
            return sb.ToString();
        }
    }
}
