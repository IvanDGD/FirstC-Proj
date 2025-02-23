using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class CreditCard
    {

        public int Balance { get; set; }
        public int CVC { get; set; }

        public CreditCard() { }

        public CreditCard(int balance, int cvc)
        {
            Balance = balance;
            CVC = cvc;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static int operator +(CreditCard bal, int value)
        {
            return bal.Balance + value;
        }

        public static int operator -(CreditCard bal, int value)
        {
            return bal.Balance - value;
        }

        public static bool operator ==(CreditCard popul1, CreditCard popul2)
        {
            return popul1.Equals(popul2);
        }
        public static bool operator !=(CreditCard emp1, CreditCard emp2)
        {
            return !(emp1 == emp2);
        }
        public static bool operator >(CreditCard cvc1, CreditCard cvc2)
        {
            return cvc1.CVC > cvc2.CVC;
        }

        public static bool operator <(CreditCard cvc1, CreditCard cvc2)
        {
            return cvc1.CVC < cvc2.CVC;
        }


        public override string ToString()
        {
            return $"Balance: {Balance}\nCVC: {CVC}";
        }

    }
}
