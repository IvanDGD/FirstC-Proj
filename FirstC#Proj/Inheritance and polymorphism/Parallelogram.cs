using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Parallelogram : GeometricFigure
    {
        private double baseLength, height, side;

        public Parallelogram(double baseLength, double height, double side)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.side = side;
        }

        public override double Area() => baseLength * height;

        public override double Perimeter() => 2 * (baseLength + side);
    }
}
