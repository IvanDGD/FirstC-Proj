using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class Car
    {
        public string Model { get; }
        public string Color { get; }

        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
    }
}
