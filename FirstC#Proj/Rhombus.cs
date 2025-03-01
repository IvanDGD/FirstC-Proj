using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Rhombus : GeometricFigure
    {
        private double diagonal1, diagonal2, side;

        public Rhombus(double diagonal1, double diagonal2, double side)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            this.side = side;
        }

        public override double Area() => (diagonal1 * diagonal2) / 2;

        public override double Perimeter() => 4 * side;
    }
}
