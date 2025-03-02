using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Product
    {
        public string Name { get; set; }
        private int quantity;
        private decimal price;

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    Console.WriteLine("Quantity cannot be negative.");
                quantity = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    Console.WriteLine("Price cannot be negative.");
                price = value;
            }
        }

        public Product(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public static Product operator +(Product p, int amount)
        {
            return new Product(p.Name, p.Quantity + amount, p.Price);
        }

        public static Product operator -(Product p, int amount)
        {
            if (p.Quantity - amount < 0)
                Console.WriteLine("Resulting quantity cannot be negative.");
            return new Product(p.Name, p.Quantity - amount, p.Price);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Price == p2.Price;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Product p1, Product p2)
        {
            return p1.Quantity > p2.Quantity;
        }

        public static bool operator <(Product p1, Product p2)
        {
            return p1.Quantity < p2.Quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is Product product && this == product;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Quantity, Price);
        }

        public override string ToString()
        {
            return $"{Name}: {Quantity} pcs, ${Price}";
        }
    }
}
