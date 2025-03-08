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
            Money m1 = new Money(10, 50);
            Money m2 = new Money(5, 75);
            Money result;

            Console.WriteLine("Start sum:");
            m1.Display();
            m2.Display();

            result = m1 + m2;
            Console.Write("Addition: ");
            result.Display();

            result = m1 - m2;
            Console.Write("Subtraction: ");
            result.Display();

            result = m1 * 2;
            Console.Write("Multiplication by 2: ");
            result.Display();

            result = m1 / 2;
            Console.Write("Division by 2: ");
            result.Display();

            Console.Write("Increment (m1++): ");
            m1++;
            m1.Display();

            Console.Write("Decrement (m1--): ");
            m1--;
            m1.Display();

            try
            {
                result = m2 - m1;
                Console.Write("Subtraction (m2 - m1): ");
                result.Display();
            }
            catch (BankruptException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
