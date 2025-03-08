using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Money
    {
        private int _UAH;
        private int _pennies;

        public Money(int uah = 0, int pennies = 0)
        {
            SetMoney(uah, pennies);
        }

        private void Normalize()
        {
            if (_pennies >= 100)
            {
                _UAH += _pennies / 100;
                _pennies %= 100;
            }
            while (_pennies < 0)
            {
                if (_UAH == 0) throw new BankruptException("Not enogth money!");
                _UAH--;
                _pennies += 100;
            }
        }

        public void SetMoney(int uah, int pennies)
        {
            _UAH = uah;
            _pennies = pennies;
            Normalize();
        }

        public void Display()
        {
            Console.WriteLine($"{_UAH}.{_pennies:D2} UAH");
        }

        public static Money operator +(Money m1, Money m2)
        {
            return new Money(m1._UAH + m2._UAH, m1._pennies + m2._pennies);
        }

        public static Money operator -(Money m1, Money m2)
        {
            int totalPennies1 = m1._UAH * 100 + m1._pennies;
            int totalPennies2 = m2._UAH * 100 + m2._pennies;
            if (totalPennies1 < totalPennies2) throw new BankruptException("Not enogth money!");

            return new Money(0, totalPennies1 - totalPennies2);
        }

        public static Money operator *(Money money, int factor)
        {
            if (factor < 0) throw new ArgumentException("You cannot multiply on negative number!!");
            return new Money(0, (money._UAH * 100 + money._pennies) * factor);
        }

        public static Money operator /(Money money, int divisor)
        {
            if (divisor <= 0) throw new ArgumentException("Divisor cannot be negative number");
            return new Money(0, (money._UAH * 100 + money._pennies) / divisor);
        }

        public static Money operator ++(Money money)
        {
            return new Money(money._UAH, money._pennies + 1);
        }

        public static Money operator --(Money money)
        {
            if (money._UAH == 0 && money._pennies == 0) throw new BankruptException("Not enogth money!");
            return new Money(money._UAH, money._pennies - 1);
        }

        public override int GetHashCode()
        {
            return (_UAH, _pennies).GetHashCode();
        }
    }
}
