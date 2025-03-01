using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Square : GeometricFigure
    {
        private double side;

        public Square(double side) => this.side = side;

        public override double Area() => side * side;

        public override double Perimeter() => 4 * side;
    }
}
