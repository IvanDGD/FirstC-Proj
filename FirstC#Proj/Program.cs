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
            //Product apple = new Product("Apple", 2, 50);
            //apple.Show();

            //apple.Discount(30);
            //apple.Show();
            #endregion
            #region Task2
            //Device[] devices =
            //{
            //    new Kettle("Electric Kettle", "Philips", 1.5, 2200),
            //    new Microwave("Kitchen Microwave", "Samsung", 30, 1000),
            //    new Car("Sport Car", "Ferrari", 3.9, 710),
            //    new Steamer("Ocean Steamer", "Steam Turbine", 50000, 30)
            //};

            //foreach (var device in devices)
            //{
            //    device.Show();
            //    device.Sound();
            //    device.Desc();
            //    Console.WriteLine();
            //}
            #endregion
            #region Task3
            //MusicalInstruments[] instruments =
            //{
            //    new Violin("Stradivarius Violin", "Maple & Spruce", 4),
            //    new Trombone("Yamaha Trombone", "Tenor", 130),
            //    new Ukulele("Kala Ukulele", "Concert", 4),
            //    new Cello("Guarneri Cello", "Full Size", "Horsehair")
            //};

            //foreach (var instrument in instruments)
            //{
            //    instrument.Show();
            //    instrument.Sound();
            //    instrument.Desc();
            //    instrument.History();
            //    Console.WriteLine();
            //}
            #endregion
            #region Task4
            //Worker[] workers =
            //{
            //    new President("Alice Johnson"),
            //    new Security("Bob Smith"),
            //    new Manager("Charlie Davis"),
            //    new Engineer("David Brown")
            //};

            //foreach (var worker in workers)
            //{
            //    worker.Print();
            //    Console.WriteLine();
            //}
            #endregion
            #region Task5
            //Course offlineCourse = new Course("Mathematics", 40);
            //OnlineCourse onlineCourse = new OnlineCourse("C# Programming", 30, "Udemy");

            //Console.WriteLine(offlineCourse);
            //Console.WriteLine(onlineCourse);
            #endregion
            #region Task6
            List<Product> products = new List<Product>
            {
                new Electronics("Smartphone", 1000),
                new Electronics("Laptop", 1500),
                new Furniture("Sofa", 800),
                new Furniture("Dining Table", 1200)
            };

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            #endregion
        }
    }
}
