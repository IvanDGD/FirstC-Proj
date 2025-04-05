using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.LINQ
{
    internal class Firm
    {
        public string Name;
        public DateTime FoundationDate;
        public string BusinessProfile;
        public string DirectorFullName;
        public int EmployeeCount;
        public string Address;

        public void PrintInfo()
        {
            Console.WriteLine("Назва: " + Name);
            Console.WriteLine("Дата заснування: " + FoundationDate.ToShortDateString());
            Console.WriteLine("Профіль бізнесу: " + BusinessProfile);
            Console.WriteLine("Директор: " + DirectorFullName);
            Console.WriteLine("Кількість співробітників: " + EmployeeCount);
            Console.WriteLine("Адреса: " + Address);
            Console.WriteLine();
        }
    }
}
