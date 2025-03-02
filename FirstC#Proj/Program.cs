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

            //ReadList myList = new ReadList();

            //Book book1 = new Book("1984", "George Orwell");
            //Book book2 = new Book("Brave New World", "Aldous Huxley");
            //Book book3 = new Book("Fahrenheit 451", "Ray Bradbury");

            //myList += book1;
            //myList += book2;
            //myList += book3;

            //myList.ShowList();


            //myList -= book2;
            //myList.ShowList();

            #endregion
            #region Task2
            //TemperatureArray weeklyTemps = new TemperatureArray();

            //weeklyTemps[0] = 15.5;
            //weeklyTemps[1] = 17.3;
            //weeklyTemps[2] = 19.0;
            //weeklyTemps[3] = 18.2;
            //weeklyTemps[4] = 20.1;
            //weeklyTemps[5] = 22.8;
            //weeklyTemps[6] = 21.4;

            //weeklyTemps.ShowTemperatures();

            //Console.WriteLine("Temperature on Wednesday: " + weeklyTemps[2] + "°C");
            #endregion
            #region Task3
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(2, 5);

            Console.WriteLine($"f1: {f1}");
            Console.WriteLine($"f2: {f2}");

            Console.WriteLine($"f1 + f2 = {f1 + f2}");
            Console.WriteLine($"f1 - f2 = {f1 - f2}");
            Console.WriteLine($"f1 * f2 = {f1 * f2}");
            Console.WriteLine($"f1 / f2 = {f1 / f2}");

            Console.WriteLine($"f1 == f2: {f1 == f2}");
            Console.WriteLine($"f1 != f2: {f1 != f2}");
            #endregion
            #region Task4
            //Product product1 = new Product("Laptop", 10, 999.99m);
            //Product product2 = new Product("Tablet", 5, 499.99m);

            //Console.WriteLine(product1);
            //Console.WriteLine(product2);

            //product1 += 5;
            //Console.WriteLine("After adding 5: " + product1);

            //product2 -= 2;
            //Console.WriteLine("After removing 2: " + product2);

            //Console.WriteLine("Are prices equal? " + (product1 == product2));
            //Console.WriteLine("Is product1 quantity greater than product2? " + (product1 > product2));
            #endregion
        }



    }
}
