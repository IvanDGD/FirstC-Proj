using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.LINQ
{
    internal class Employee
    {
        public string FullName;
        public string Position;
        public string PhoneNumber;
        public string Email;
        public int Salary;

        public void PrintInfo()
        {
            Console.WriteLine("ПІБ: " + FullName);
            Console.WriteLine("Посада: " + Position);
            Console.WriteLine("Телефон: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Зарплата: " + Salary);
            Console.WriteLine();
        }
    }
}
