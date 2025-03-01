using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Trapezoid : GeometricFigure
    {
        private double base1, base2, height, side1, side2;

        public Trapezoid(double base1, double base2, double height, double side1, double side2)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area() => ((base1 + base2) * height) / 2;

        public override double Perimeter() => base1 + base2 + side1 + side2;
    }
}
