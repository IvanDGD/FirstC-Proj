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
            #region Task1

            //Console.WriteLine("Enter a number:");

            //string input = Console.ReadLine();

            //try
            //{
            //    int number = (checked(int.Parse(input)));
            //    Console.WriteLine($"Converted number: {number}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid integer.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Overflow exception! The number is out of the range of int.");
            //}

            #endregion
            #region Task2

            //string numStr;

            //Console.WriteLine("Enter str (0 or 1)");
            //numStr = Console.ReadLine();

            //try
            //{
            //    int numInt = Convert.ToInt32(numStr, 2);
            //    Console.WriteLine($"Converted number: {numInt}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid integer.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Overflow exception! The number is out of the range of int.");
            //}
            #endregion
            #region Task3
            //try
            //{
            //    CreditCard card1 = new CreditCard("1234567890123456", "John Doe", new DateTime(2027, 12, 31), "123", 5000);
            //    CreditCard card2 = new CreditCard("9876543210987654", "Jane Smith", new DateTime(2026, 5, 31), "456", 7000);

            //    Console.WriteLine(card1);
            //    Console.WriteLine(card2);

            //    card1 += 2000;
            //    card2 -= 3000;

            //    Console.WriteLine("After transactions:");
            //    Console.WriteLine(card1);
            //    Console.WriteLine(card2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion
            #region Task4
            Console.WriteLine("Enter a mathematical expression (example, 3*2*1*4):");
            string input = Console.ReadLine();

            try
            {
                int result = CalculateExpression(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion
        }
        static int CalculateExpression(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("The expression cannot be empty.");

            string[] parts = expression.Split('*');
            int result = 1;

            foreach (string part in parts)
            {
                if (!int.TryParse(part.Trim(), out int number))
                    throw new FormatException("Invalid input format. The expression must contain only integers and *.");

                result *= number;
            }

            return result;
        }
    }
}
