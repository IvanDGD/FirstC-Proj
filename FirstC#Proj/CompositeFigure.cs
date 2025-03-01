using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class CompositeFigure
    {
        private List<GeometricFigure> figures = new List<GeometricFigure>();

        public void AddFigure(GeometricFigure figure) => figures.Add(figure);

        public double TotalArea()
        {
            double total = 0;
            foreach (var figure in figures)
            {
                total += figure.Area();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Composite Figure:");
            foreach (var figure in figures)
            {
                sb.AppendLine(figure.ToString());
            }
            sb.AppendLine($"Total Area: {TotalArea():F2}");
            return sb.ToString();
        }
    }
}
