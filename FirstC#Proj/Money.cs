using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Money
    {
        private int whole;
        private int cents;

        public Money(int w = 0, int c = 0)
        {
            SetMoney(w, c);
        }

        public void SetMoney(int w, int c)
        {
            whole = w;
            cents = c;
            Normalize();
        }

        public void Display()
        {
            Console.WriteLine($"{whole}.{cents:D2}");
        }

        public void Decrease(int amount)
        {
            int totalCents = whole * 100 + cents - amount;
            if (totalCents < 0)
            {
                totalCents = 0;
            }
            whole = totalCents / 100;
            cents = totalCents % 100;
        }

        private void Normalize()
        {
            if (cents >= 100)
            {
                whole += cents / 100;
                cents %= 100;
            }
        }
    }
}
