using System;

namespace FirstC_Proj
{
    public static class ExtensionMethods
    {

        public static void IsNumOdd(this int num)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine($"{num} is odd");
            }
        }
        public static void IsNumDouble(this int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is double");
            }
        }
        public static void IsNumNatural(this int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is natural");
            }
            else
            {
                Console.WriteLine($"{num} isn't natural");
            }
        }
        public static int CountVowels(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            const string vowels = "aeiouAEIOU";
            return str.Count(c => vowels.Contains(c));
        }
        public static int CountConsonants(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            const string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            return str.Count(c => consonants.Contains(c));
        }
        public static int CountSentence(this string str)
        {
            return str.Split(',', '.').Length;
        }
        public static string ReverseString(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static double AverageAge(this Person[] persons)
        {
            if (persons == null || persons.Length == 0)
                return 0;

            return persons.Average(p => p.age);
        }
        public static Fraction2 MaxFraction(this Fraction2[] fractions)
        {
            Fraction max = fractions[0];

            foreach (var fraction in fractions)
            {
                if (fraction.Numerator * max.Denominator > max.Numerator * fraction.Denominator)
                {
                    max = fraction;
                }
            }

            return max;
        }
        public static Fraction2 MinFraction(this Fraction2[] fractions)
        {
            Fraction min = fractions[0];

            foreach (var fraction in fractions)
            {
                if (fraction.Numerator * min.Denominator < min.Numerator * fraction.Denominator)
                {
                    min = fraction;
                }
            }

            return min;
        }
    }

    public record Person(string name, string surname, int age);
    public record Point3D(double X, double Y, double Z);
    public record Fraction2(int Numerator, int Denominator);

    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int num = 93;
            num.IsNumOdd();
            #endregion
            #region Task2
            int num2 = 10;
            num2.IsNumDouble();
            #endregion
            #region Task3
            int num3 = 3;
            num.IsNumNatural();
            #endregion
            #region Task4
            string str = "Hello, world";
            Console.WriteLine($"Count vowels {str.CountVowels()}");
            #endregion
            #region Task5
            string str2 = "Hello, world";
            Console.WriteLine($"Count consonants {str2.CountConsonants()}");
            #endregion
            #region Task6
            string str3 = "Hello, world";
            Console.WriteLine($"Count sentence {str3.CountSentence()}");
            #endregion
            #region Task7
            string str4 = "Hello, World!";
            string reversed = str4.ReverseString();
            Console.WriteLine($"Original: {str4}");
            Console.WriteLine($"Reversed: {reversed}");
            #endregion
            #region Task8
            Person[] people = new Person[]
            {
               new Person("John", "Doe", 28),
               new Person("Jane", "Smith", 34),
               new Person("Alice", "Johnson", 25),
               new Person("Bob", "Brown", 40),
               new Person("Charlie", "Davis", 30)
            };

            Person youngest = people[0];
            Person oldest = people[0];

            foreach (var person in people)
            {
                if (person.age < youngest.age)
                {
                    youngest = person;
                }

                if (person.age > oldest.age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"Youngest: {youngest.name} {youngest.surname}, Age: {youngest.age}");
            Console.WriteLine($"Oldest: {oldest.name} {oldest.surname}, Age: {oldest.age}");

            double averageAge = people.AverageAge();
            Console.WriteLine($"Average Age: {averageAge}");
            #endregion
            #region Task9
            Point3D[] points = new Point3D[]
            {
                new Point3D(1, 2, 3),
                new Point3D(4, 5, 6),
                new Point3D(7, 8, 9),
                new Point3D(1, 0, 0),
                new Point3D(0, 0, 0)
            };

            double maxDistance = 0;
            Point3D pointA = points[0];
            Point3D pointB = points[0];

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        pointA = points[i];
                        pointB = points[j];
                    }
                }
            }

            Console.WriteLine($"Maximum Distance: {maxDistance}");
            Console.WriteLine($"Between Points: {pointA} and {pointB}");
            #endregion
            #region Task10
            Fraction2[] fractions = new Fraction2[]
            {
                new Fraction2(1, 2),
                new Fraction2(3, 4),
                new Fraction2(2, 3),
                new Fraction2(5, 6),
                new Fraction2(1, 3) 
            };

            Fraction2 maxFraction = fractions.MaxFraction();
            Fraction2 minFraction = fractions.MinFraction();

            Console.WriteLine($"Maximum Fraction: {maxFraction.Numerator}/{maxFraction.Denominator}");
            Console.WriteLine($"Minimum Fraction: {minFraction.Numerator}/{minFraction.Denominator}");
            #endregion
        }
        static double CalculateDistance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2) + Math.Pow(p2.Z - p1.Z, 2));
        }
    }
}