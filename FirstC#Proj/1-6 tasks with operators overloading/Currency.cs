using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Currency
    {

        public string Name { get; set; }
        public double ExchangeRate { get; set; }

        public Currency() { }

        public Currency(string name, double exchangeRate)
        {
            Name = name;
            ExchangeRate = exchangeRate;
        }

        public static explicit operator Currency(double amountInUsd)
        {
            return new Currency("USD", amountInUsd);
        }

        public static implicit operator double(Currency currency)
        {
            return currency.ExchangeRate;
        }

        public static double operator *(double amount, Currency currency)
        {
            return amount * currency.ExchangeRate;
        }

        public static double operator /(double amount, Currency currency)
        {
            return amount / currency.ExchangeRate;
        }

        public override string ToString()
        {
            return $"Currency: {Name}, Exchange Rate: {ExchangeRate}";
        }

    }
}
