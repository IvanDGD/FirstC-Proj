using System;
using FirstC_Proj.Delegate;

namespace FirstC_Proj
{

    class Program
    {
        public delegate bool NumberCondition(int number);
        static Action ShowCurrentTime;
        static Action ShowCurrentDate;
        static Action ShowCurrentDay;
        static Func<double, double, double> CalculateTriangleArea;
        static Func<double, double, double> CalculateRectangleArea;

        static Predicate<(double a, double b, double c)> IsTriangleValid;

        static void Main()
        {
            #region Task1
            //int[] numbers = { 1, 2, 3, 5, 8, 13, 17, 19, 21, 34, 55, 89 };
            //Console.Write("Even Numbers: ");
            //PrintArray(FilterArray(numbers, IsEven));
            //Console.Write("Odd Numbers: ");
            //PrintArray(FilterArray(numbers, IsOdd));
            //Console.Write("Prime Numbers: ");
            //PrintArray(FilterArray(numbers, IsPrime));
            //Console.Write("Fibonacci Numbers: ");
            //PrintArray(FilterArray(numbers, IsFibonacci));
            #endregion
            #region Task2
            //ShowCurrentTime = new Action(DisplayCurrentTime);
            //ShowCurrentDate = new Action(DisplayCurrentDate);
            //ShowCurrentDay = new Action(DisplayCurrentDay);

            //CalculateTriangleArea = new Func<double, double, double>(TriangleArea);
            //CalculateRectangleArea = new Func<double, double, double>(RectangleArea);

            //IsTriangleValid = new Predicate<(double a, double b, double c)>(TriangleValidityCheck);

            //ShowCurrentTime();
            //ShowCurrentDate();
            //ShowCurrentDay();

            //Console.WriteLine("Area (base=5, height=10): " + CalculateTriangleArea(5, 10));
            //Console.WriteLine("Area (width=4, height=6): " + CalculateRectangleArea(4, 6));

            //var triangleSides = (a: 3, b: 4, c: 5);
            //Console.WriteLine($"Can a triangle exist with sides {triangleSides.a}, {triangleSides.b}, {triangleSides.c}? {IsTriangleValid(triangleSides)}");
            #endregion
            #region Task3
            //CreditCard myCard = new CreditCard("1234-5678-9012-3456", "John Doe", "12/27", "1234", 5000.0, 1000.0);

            //myCard.Deposit(500.0);
            //myCard.Withdraw(1200.0);
            //myCard.CheckTargetBalance(1500.0);
            //myCard.ChangePin("4321");
            #endregion
            #region Task4
            Counter.StringDelegate vowelCounter = Counter.CountVowels;
            Counter.StringDelegate consonantCounter = Counter.CountConsonants;
            Counter.StringDelegate lengthCounter = Counter.GetStringLength;

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Number of vowels: {vowelCounter(input)}");
            Console.WriteLine($"Number of consonants: {consonantCounter(input)}");
            Console.WriteLine($"String length: {lengthCounter(input)}");
            #endregion
        }

        static void DisplayCurrentTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToLongTimeString());
        }

        static void DisplayCurrentDate()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToShortDateString());
        }

        static void DisplayCurrentDay()
        {
            Console.WriteLine("Current Day: " + DateTime.Now.DayOfWeek);
        }

        static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        static bool TriangleValidityCheck((double a, double b, double c) sides)
        {
            return (sides.a + sides.b > sides.c) &&
                   (sides.a + sides.c > sides.b) &&
                   (sides.b + sides.c > sides.a);
        }

        static int[] FilterArray(int[] array, NumberCondition condition)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (condition(num)) count++;
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int num in array)
            {
                if (condition(num))
                {
                    result[index++] = num;
                }
            }

            return result;
        }

        static void PrintArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static bool IsEven(int number) => number % 2 == 0;

        static bool IsOdd(int number) => number % 2 != 0;

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b == number || number == 0;
        }
    }
}