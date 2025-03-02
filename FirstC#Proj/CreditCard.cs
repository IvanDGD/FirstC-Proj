using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace FirstC_Proj
{
    internal class CreditCard
    {
        private string _cardNumber;
        private string _fullName;
        private DateTime _endDate;
        private string _cvc;
        private int _balance;

        public string CardNumber
        {
            get => _cardNumber;
            set
            {
                if (value.Length < 13 || value.Length > 19 || !long.TryParse(value, out _))
                    throw new ArgumentException("Invalid card number! It must be 13-19 digits.");
                _cardNumber = value;
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full name cannot be empty!");
                _fullName = value;
            }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                if (value < DateTime.Now)
                    throw new ArgumentException("The card is expired!");
                _endDate = value;
            }
        }

        public string CVC
        {
            get => _cvc;
            set
            {
                if (value.Length != 3 || !int.TryParse(value, out _))
                {
                    throw new ArgumentException("CVC must be exactly 3 digits.");
                }
                _cvc = value;
            }
        }

        public int Balance
        {
            get => _balance;
            private set
            {
                _balance = value;
            }
        }

        public CreditCard() { }

        public CreditCard(string cardNumber, string fullName, DateTime endDate, string cvc, int balance)
        {
            CardNumber = cardNumber;
            FullName = fullName;
            EndDate = endDate;
            CVC = cvc;
            Balance = balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard other)
            {
                return CardNumber == other.CardNumber &&
                       FullName == other.FullName &&
                       CVC == other.CVC &&
                       EndDate == other.EndDate;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CardNumber, FullName, CVC, EndDate);
        }

        public static CreditCard operator +(CreditCard card, int amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, int amount)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative!");
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (card1 is null || card2 is null) return false;
            return card1.Equals(card2);
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public override string ToString()
        {
            return $"Card Number: {CardNumber}\n" +
                   $"Full Name: {FullName}\n" +
                   $"End Date: {EndDate:mm/yyyy}\n" +
                   $"CVC: ***\n" +
                   $"Balance: {Balance}$";
        }
    }
}

