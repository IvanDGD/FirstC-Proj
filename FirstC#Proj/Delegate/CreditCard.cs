using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.Delegate
{
    internal class CreditCard
    {
        public string CardNumber { get; private set; }
        public string OwnerName { get; private set; }
        public string ExpirationDate { get; private set; }
        public string Pin { get; private set; }
        public double CreditLimit { get; private set; }
        public double Balance { get; private set; }

        public CreditCard(string number, string name, string expDate, string pin, double limit, double startBalance)
        {
            CardNumber = number;
            OwnerName = name;
            ExpirationDate = expDate;
            Pin = pin;
            CreditLimit = limit;
            Balance = startBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else if (Balance + CreditLimit > amount)
            {
                Balance -= amount;
                Console.WriteLine("Using credit money!");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void CheckTargetBalance(double target)
        {
            if (Balance > target)
            {
                Console.WriteLine($"Target balance reached: {Balance}");
            }
        }

        public void ChangePin(string newPin)
        {
            Pin = newPin;
            Console.WriteLine("PIN changed successfully!");
        }
    }
}
