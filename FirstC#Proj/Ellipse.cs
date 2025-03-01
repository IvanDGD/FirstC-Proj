using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Ellipse : GeometricFigure
    {
        private double semiMajorAxis, semiMinorAxis;

        public Ellipse(double semiMajorAxis, double semiMinorAxis)
        {
            this.semiMajorAxis = semiMajorAxis;
            this.semiMinorAxis = semiMinorAxis;
        }

        public override double Area() => Math.PI * semiMajorAxis * semiMinorAxis;

        public override double Perimeter() => Math.PI * (3 * (semiMajorAxis + semiMinorAxis) - Math.Sqrt((3 * semiMajorAxis + semiMinorAxis) * (semiMajorAxis + 3 * semiMinorAxis)));
    }
}
