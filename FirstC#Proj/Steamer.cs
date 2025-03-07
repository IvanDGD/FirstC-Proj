using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Steamer : Device
    {
        private string EngineType;
        private double Displacement;
        private int Speed;

        public Steamer(string name, string engineType, double displacement, int speed)
            : base(name, $"Engine Type: {engineType}, Displacement: {displacement} tons, Speed: {speed} knots")
        {
            EngineType = engineType;
            Displacement = displacement;
            Speed = speed;
        }

        public override void Sound()
        {
            Console.WriteLine("Pshhhhhh-chuff");
        }

        public override void Show()
        {
            Console.WriteLine($"Steamer: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Engine type: {EngineType}\nDisplacement: {Displacement} tons\nSpeed: {Speed} knots");
        }

    }
}
