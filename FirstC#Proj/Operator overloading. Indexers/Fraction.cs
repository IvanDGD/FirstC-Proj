using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Fraction
    {
       public int Numerator { get; set; }
       private int denominator;

       public int Denominator
       {
           get => denominator;
           set
           {
               if (value == 0)
                   throw new ArgumentException("Denominator cannot be zero.");
               denominator = value;
           }
       }

       public Fraction(int numerator, int denominator)
       {
           Numerator = numerator;
           Denominator = denominator;
           Simplify();
       }

       private void Simplify()
       {
           int gcd = GCD(Abs(Numerator), Abs(Denominator));
           Numerator /= gcd;
           Denominator /= gcd;
           if (Denominator < 0)
           {
               Numerator = -Numerator;
               Denominator = -Denominator;
           }
       }

       private int Abs(int value)
       {
           return value < 0 ? -value : value;
       }

       private int GCD(int a, int b)
       {
           while (b != 0)
           {
               int temp = b;
               b = a % b;
               a = temp;
           }
           return a;
       }

       public static Fraction operator +(Fraction a, Fraction b)
       {
           int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
           int denominator = a.Denominator * b.Denominator;
           return new Fraction(numerator, denominator);
       }

       public static Fraction operator -(Fraction a, Fraction b)
       {
           int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
           int denominator = a.Denominator * b.Denominator;
           return new Fraction(numerator, denominator);
       }

       public static Fraction operator *(Fraction a, Fraction b)
       {
           return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
       }

       public static Fraction operator /(Fraction a, Fraction b)
       {
           if (b.Numerator == 0)
               throw new DivideByZeroException("Cannot divide by a fraction with zero numerator.");
           return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
       }

       public static bool operator ==(Fraction a, Fraction b)
       {
           return a.Numerator * b.Denominator == b.Numerator * a.Denominator;
       }

       public static bool operator !=(Fraction a, Fraction b)
       {
           return !(a == b);
       }

        public override bool Equals(object? obj)
        {
            return obj is Fraction fraction && this == fraction;
        }

        public override int GetHashCode()
       {
           return HashCode.Combine(Numerator, Denominator);
       }

       public override string ToString()
       {
           return $"{Numerator}/{Denominator}";
       }
       
    }
}
