using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Product
    {
        private string name;
        private Money price;

        public Product(string n, int w, int c)
        {
            name = n;
            price = new Money(w, c);
        }

        public void SetPrice(int w, int c)
        {
            price.SetMoney(w, c);
        }

        public void Show()
        {
            Console.Write($"Product: {name}, Price: ");
            price.Display();
        }

        public void Discount(int amount)
        {
            price.Decrease(amount);
        }
    }
}
