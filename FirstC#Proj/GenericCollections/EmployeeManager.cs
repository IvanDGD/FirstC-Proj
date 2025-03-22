using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(string email)
        {
            Employee employee = null;
            foreach (var e in employees)
            {
                if (e.Email.ToLower() == email.ToLower())
                {
                    employee = e;
                    break;
                }
            }

            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine($"Employee {employee.FullName} removed.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void UpdateEmployee(string email, Employee updatedEmployee)
        {
            foreach (var e in employees)
            {
                if (e.Email.ToLower() == email.ToLower())
                {
                    e.FullName = updatedEmployee.FullName;
                    e.Position = updatedEmployee.Position;
                    e.Salary = updatedEmployee.Salary;
                    e.Email = updatedEmployee.Email;
                    Console.WriteLine($"Employee {e.FullName} updated.");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        public List<Employee> SearchEmployees(string searchTerm)
        {
            List<Employee> result = new List<Employee>();
            foreach (var e in employees)
            {
                if (e.FullName.ToLower().Contains(searchTerm.ToLower()) ||
                    e.Position.ToLower().Contains(searchTerm.ToLower()) ||
                    e.Email.ToLower().Contains(searchTerm.ToLower()))
                {
                    result.Add(e);
                }
            }
            return result;
        }

        public List<Employee> SortEmployeesBySalary()
        {
            List<Employee> sortedEmployees = new List<Employee>(employees);
            for (int i = 0; i < sortedEmployees.Count - 1; i++)
            {
                for (int j = 0; j < sortedEmployees.Count - 1 - i; j++)
                {
                    if (sortedEmployees[j].Salary > sortedEmployees[j + 1].Salary)
                    {
                        var temp = sortedEmployees[j];
                        sortedEmployees[j] = sortedEmployees[j + 1];
                        sortedEmployees[j + 1] = temp;
                    }
                }
            }
            return sortedEmployees;
        }

        public List<Employee> SortEmployeesByName()
        {
            List<Employee> sortedEmployees = new List<Employee>(employees);
            for (int i = 0; i < sortedEmployees.Count - 1; i++)
            {
                for (int j = 0; j < sortedEmployees.Count - 1 - i; j++)
                {
                    if (sortedEmployees[j].FullName.CompareTo(sortedEmployees[j + 1].FullName) > 0)
                    {
                        var temp = sortedEmployees[j];
                        sortedEmployees[j] = sortedEmployees[j + 1];
                        sortedEmployees[j + 1] = temp;
                    }
                }
            }
            return sortedEmployees;
        }

        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
