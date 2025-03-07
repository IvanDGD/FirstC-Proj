using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Car : Device
    {
        private string Brand;
        private double EngineVolume;
        private int Power;

        public Car(string name, string brand, double engineVolume, int power)
            : base(name, $"Brand: {brand}, Engine Volume: {engineVolume}L, Power: {power} HP")
        {
            Brand = brand;
            EngineVolume = engineVolume;
            Power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Vroooommm-shhh");
        }

        public override void Show()
        {
            Console.WriteLine($"Car: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Car power: {Power} HP\nBrand: {Brand}\nEngine volume: {EngineVolume}L");
        }

    }
}
