using System;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task2

            //ForeignPassport foreignPassport = new ForeignPassport("John", "Doe", "USA", "12345678", "15/5/1990", "87654321");
            //foreignPassport.AddVisa("Schengen Visa");
            //foreignPassport.AddVisa("UK Visa");

            //Console.WriteLine(foreignPassport);

            #endregion
            #region Task3

            //Animal tiger = new Tiger("Bengal Tiger", "Large wild cat with orange fur and black stripes.");
            //Animal crocodile = new Crocodile("Nile Crocodile", "Large aquatic reptile with powerful jaws.");
            //Animal kangaroo = new Kangaroo("Red Kangaroo", "Marsupial known for its strong hind legs and jumping abilities.");

            //// Зробіть звук на мінмалку

            //Console.WriteLine(tiger);
            //tiger.DoSound();
            //Console.WriteLine();

            //Console.WriteLine(crocodile);
            //crocodile.DoSound();
            //Console.WriteLine();

            //Console.WriteLine(kangaroo);
            //kangaroo.DoSound();
            #endregion
            #region Task4
            CompositeFigure composite = new CompositeFigure();
            composite.AddFigure(new Triangle(3, 4, 5));
            composite.AddFigure(new Square(4));
            composite.AddFigure(new Rectangle(5, 6));
            composite.AddFigure(new Rhombus(6, 8, 5));
            composite.AddFigure(new Parallelogram(7, 5, 6));
            composite.AddFigure(new Trapezoid(5, 7, 4, 3, 3));
            composite.AddFigure(new Circle(3));
            composite.AddFigure(new Ellipse(5, 3));

            Console.WriteLine(composite);
            #endregion

        }



    }
}
