using System;
using System.Globalization;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //Console.Write("Enter num: ");
            //string input = Console.ReadLine();

            //int.TryParse(input, out int value);

            //FizzBuzzGame(value);

            #endregion

            #region Task2

            //Console.Write("Enter num: ");
            //string input2 = Console.ReadLine();

            //Console.Write("Enter percent: ");
            //string percent = Console.ReadLine();

            //int.TryParse(input2, out int value2);
            //int.TryParse(percent, out int percentValue);

            //int result = (value2 * percentValue) / 100;

            //Console.WriteLine($"Result: {result}");

            #endregion

            #region Task3

            //Console.Write("Enter first digit: ");
            //int digit1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second digit: ");
            //int digit2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third digit: ");
            //int digit3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter fourth digit: ");
            //int digit4 = int.Parse(Console.ReadLine());

            //int result = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            //Console.WriteLine($"Result: {result}");

            #endregion

            #region Task4

            //Console.Write("Enter a six digit number: ");
            //string input = Console.ReadLine();

            //if (!IsValidSixDigitNumber(input))
            //{
            //    Console.WriteLine("Error: You must enter a six digit number!");
            //    return;
            //}

            //string result = SwapFirstAndLastDigit(input);
            //Console.WriteLine($"Result: {result}");

            #endregion

            #region Task5

            //Console.Write("Enter a date (dd.mm.yyyy): ");
            //string input = Console.ReadLine();

            //if (DateTime.TryParseExact(input, "dd.mm.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            //{
            //    string season = GetSeason(date);
            //    string dayOfWeek = date.DayOfWeek.ToString();
            //    Console.WriteLine($"{season} {dayOfWeek}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid date format. Please enter in format dd.mm.yyyy.");
            //}

            #endregion

            #region Task6

            //TemperatureTranslator();

            #endregion

            #region Task7

            //FindingPairedNumInRange();

            #endregion

            #region Task8

            //if (IsArmstrongNum())
            //{
            //    Console.WriteLine("Your number is armstrong number");
            //}
            //else
            //{
            //    Console.WriteLine("Your number isn't armstrong number");
            //}

            #endregion

            #region Task9

            Console.Write("Enter num: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            
            if (IsPerfectNumber(number))
            {
                Console.WriteLine($"{number} is perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} isn't perfect number.");
            }

            #endregion

        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        static bool IsArmstrongNum()
        {
            Console.WriteLine("Enter num: ");
            string input = Console.ReadLine();

            int sumOfCubes = 0;

            if (int.TryParse(input, out int originalValue))
            {
                foreach (char c in input)
                {
                    if (int.TryParse(c.ToString(), out int digit))
                    {
                        sumOfCubes += Cube(digit);
                    }
                    else
                    {
                        Console.WriteLine($"{c} is not a valid digit.");
                        return false;
                    }
                }

                return originalValue == sumOfCubes;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return false;
            }
        }

        static int Cube(int value)
        {
            return value * value * value;
        }

        static void FindingPairedNumInRange()
        {
            Console.WriteLine("Enter start range: ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter end range: ");
            string input2 = Console.ReadLine();

            int.TryParse(input, out int value);
            int.TryParse(input2, out int value2);

            if (value < value2)
            {
                for (int i = value; i < value2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            

        }

        static void TemperatureTranslator()
        {
            Console.WriteLine("From Celsius to Fahrenheit (1)");
            Console.WriteLine("From Fahrenheit to Celsius (2)");

            Console.WriteLine("Choice: ");
            string conversionChoice = Console.ReadLine();

            Console.WriteLine("Enter temperature: ");
            string input = Console.ReadLine();

            int.TryParse(input, out int value);

            double result = 0;

            switch (conversionChoice)
            {
                case "1":
                    result = (value * 9.0 / 5.0) + 32;
                    Console.WriteLine($"Result in Fahrenheit: {result}");
                    break;
                case "2":
                    result = (value - 32) * (5.0 / 9.0);
                    Console.WriteLine($"Result in Celsius: {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        static string GetSeason(DateTime date)
        {
            return date.Month switch
            {
                12 or 1 or 2 => "Winter",
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Autumn",
                _ => "Error:"
            };
        }

        static bool IsValidSixDigitNumber(string input)
        {
            return input.Length == 6;
        }

        static string SwapFirstAndLastDigit(string number)
        {
            char[] digits = number.ToCharArray();

            (digits[0], digits[5]) = (digits[5], digits[0]);

            return new string(digits);
        }

        static void FizzBuzzGame(int value)
        {
            if (value > 1 && value < 101)
            {
                if (value % 3 == 0 && value % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (value % 3 == 0)
                {
                    Console.WriteLine("Fizz"); 
                }
                else if (value % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(value); 
                }
            }
            else
            {
                Console.WriteLine("Number out of range");
            }
        }
    }
}
