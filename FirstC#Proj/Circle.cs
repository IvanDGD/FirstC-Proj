using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Circle : GeometricFigure
    {
        private double radius;

        public Circle(double radius) => this.radius = radius;

        public override double Area() => Math.PI * radius * radius;

        public override double Perimeter() => 2 * Math.PI * radius;
    }
}
