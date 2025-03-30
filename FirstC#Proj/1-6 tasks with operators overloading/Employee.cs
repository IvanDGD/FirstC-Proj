using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Employee
    {
        public int Salary { get; set; }

        public Employee() { }

        public Employee(int salary)
        {
            Salary = salary;
        }
        public override bool Equals(object? obj)
        {
            return obj != null && this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static int operator +(Employee emp, int value)
        {
            return emp.Salary + value;
        }

        public static int operator -(Employee emp, int value)
        {
            return emp.Salary - value;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Equals(emp2);
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
        public static bool operator >(Employee emp1, Employee emp2)
        {
            if (emp1 is null || emp2 is null) return false;
            return emp1.Salary > emp2.Salary;
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            if (emp1 is null || emp2 is null) return false;
            return emp1.Salary < emp2.Salary;
        }

        public override string ToString()
        {
            return $"Salary = {Salary}";
        }
    }
}
