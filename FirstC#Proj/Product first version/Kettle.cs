using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Kettle : Device
    {
        private string Brand;
        private double Capacity;
        private int Power;

        public Kettle(string name, string brand, double capacity, int power)
            : base(name, $"Brand: {brand}, Capacity: {capacity}L, Power: {power}W")
        {
            Brand = brand;
            Capacity = capacity;
            Power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Whiiiiiissshh");
        }

        public override void Show()
        {
            Console.WriteLine($"Kettle: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Kettle power: {Power}W\nBrand: {Brand}\nCapacity: {Capacity}L");
        }
    }
}
