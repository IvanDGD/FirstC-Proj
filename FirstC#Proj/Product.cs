using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();

        public override string ToString()
        {
            return $"{Name}, Price: ${Price}, Discounted Price: ${Price - CalculateDiscount()}";
        }
    }
}
