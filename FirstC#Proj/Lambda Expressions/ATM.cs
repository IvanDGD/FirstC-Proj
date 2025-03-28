using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.Lambda_Expressions
{
    internal class ATM
    {
        private int correctPin = 3612;
        private int balance = 500;

        public delegate bool VerifyPinDelegate(int pin);
        public delegate void DisplayBalanceDelegate(int balance);
        public delegate void WithdrawMoneyDelegate(int amount);

        private VerifyPinDelegate verifyPin;
        private DisplayBalanceDelegate displayBalance;
        private WithdrawMoneyDelegate withdrawMoney;

        public ATM()
        {
            verifyPin = delegate (int enteredPin)
            {
                return enteredPin == correctPin;
            };

            displayBalance = (currentBalance) =>
            {
                Console.WriteLine("Current balance: " + currentBalance + "$");
            };

            withdrawMoney = (amount) =>
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful. New balance: " + balance + "$");
                }
                else
                {
                    Console.WriteLine("Not enough money.");
                }
            };
        }

        public void Start()
        {
            Console.Write("Enter your PIN: ");
            int enteredPin = 0;
            bool isValidPIN = int.TryParse(Console.ReadLine(), out enteredPin);

            if (!isValidPIN)
            {
                Console.WriteLine("Invalid PIN, enter number.");
                return;
            }

            if (verifyPin(enteredPin))
            {
                Console.WriteLine("PIN correct!");
                displayBalance(balance);

                Console.Write("Enter amount to withdraw: ");
                int amount = 0;
                bool isValidAmount = int.TryParse(Console.ReadLine(), out amount);

                if (isValidAmount)
                {
                    withdrawMoney(amount);
                }
                else
                {
                    Console.WriteLine("Enter a number, not letters.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect PIN.");
            }
        }
    }
}
