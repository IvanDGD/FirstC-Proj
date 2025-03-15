using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Microwave : Device
    {
        private string Brand;
        private double Capacity;
        private int Power;

        public Microwave(string name, string brand, double capacity, int power)
            : base(name, $"Brand: {brand}, Capacity: {capacity}L, Power: {power}W")
        {
            Brand = brand;
            Capacity = capacity;
            Power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Bzzzzzt-ding!");
        }

        public override void Show()
        {
            Console.WriteLine($"Microwave: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Microwave power: {Power}W\nBrand: {Brand}\nCapacity: {Capacity}L");
        }

    }
}
