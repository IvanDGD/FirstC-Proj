
using System.Text.Json;
using FirstC_Proj.LINQ;
using FirstC_Proj.Serialize;

namespace FirstC_Proj
{
    class Program
    {
        public static void PrintFirms(Firm[] firms, string title, Func<Firm, bool> condition)
        {
            Console.WriteLine(title);
            foreach (Firm f in firms)
                if (condition(f)) f.PrintInfo();
        }
        static void Main(string[] args)
        {
            #region Task1
            //Firm[] firms = new Firm[]
            //{
            //new Firm { Name = "WhiteFood", FoundationDate = DateTime.Now.AddYears(-3), BusinessProfile = "Food", DirectorFullName = "John White", EmployeeCount = 250, Address = "London" },
            //new Firm { Name = "Black&White", FoundationDate = DateTime.Now.AddDays(-123), BusinessProfile = "IT", DirectorFullName = "Steve Black", EmployeeCount = 50, Address = "Manchester" },
            //new Firm { Name = "MarketCorp", FoundationDate = DateTime.Now.AddYears(-1), BusinessProfile = "Marketing", DirectorFullName = "Anna Brown", EmployeeCount = 120, Address = "London" },
            //new Firm { Name = "TechWave", FoundationDate = DateTime.Now.AddYears(-5), BusinessProfile = "IT", DirectorFullName = "Alice White", EmployeeCount = 320, Address = "Birmingham" }
            //};

            //PrintFirms(firms, "Всі фірми:", f => true);

            //PrintFirms(firms, "Фірми з назвою, що містить 'Food':", f => f.Name.Contains("Food"));

            //PrintFirms(firms, "Фірми з профілем 'Marketing':", f => f.BusinessProfile == "Marketing");

            //PrintFirms(firms, "Фірми з профілем 'Marketing' або 'IT':", f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT");

            //PrintFirms(firms, "Фірми з кількістю співробітників більше 100:", f => f.EmployeeCount > 100);

            //PrintFirms(firms, "Фірми з кількістю співробітників від 100 до 300:", f => f.EmployeeCount >= 100 && f.EmployeeCount <= 300);

            //PrintFirms(firms, "Фірми, які знаходяться в Лондоні:", f => f.Address == "London");

            //PrintFirms(firms, "Фірми, у яких прізвище директора White:", f =>
            //{
            //    string[] parts = f.DirectorFullName.Split(' ');
            //    return parts[parts.Length - 1] == "White";
            //});

            //PrintFirms(firms, "Фірми, які засновані більше двох років тому:", f => (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2);

            //PrintFirms(firms, "Фірми, з дня заснування яких минуло 123 дні:", f => (DateTime.Now - f.FoundationDate).Days == 123);

            //PrintFirms(firms, "Фірми з прізвищем директора 'Black' та назвою, що містить 'White':", f =>
            //{
            //    string[] parts = f.DirectorFullName.Split(' ');
            //    return parts[parts.Length - 1] == "Black" && f.Name.Contains("White");
            //});
            #endregion
            #region Task2
            //Firm[] firms = new Firm[]
            //{
            //    new Firm { Name = "WhiteFood", FoundationDate = DateTime.Now.AddYears(-3), BusinessProfile = "Food", DirectorFullName = "John White", EmployeeCount = 250, Address = "London" },
            //    new Firm { Name = "Black&White", FoundationDate = DateTime.Now.AddDays(-123), BusinessProfile = "IT", DirectorFullName = "Steve Black", EmployeeCount = 50, Address = "Manchester" },
            //    new Firm { Name = "MarketCorp", FoundationDate = DateTime.Now.AddYears(-1), BusinessProfile = "Marketing", DirectorFullName = "Anna Brown", EmployeeCount = 120, Address = "London" },
            //    new Firm { Name = "TechWave", FoundationDate = DateTime.Now.AddYears(-5), BusinessProfile = "IT", DirectorFullName = "Alice White", EmployeeCount = 320, Address = "Birmingham" }
            //};

            //Console.WriteLine("Всі фірми:");
            //firms.ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми з назвою, що містить 'Food':");
            //firms.Where(f => f.Name.Contains("Food")).ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми з профілем 'Marketing':");
            //firms.Where(f => f.BusinessProfile == "Marketing").ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми з профілем 'Marketing' або 'IT':");
            //firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми з кількістю співробітників більше 100:");
            //firms.Where(f => f.EmployeeCount > 100).ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми з кількістю співробітників від 100 до 300:");
            //firms.Where(f => f.EmployeeCount >= 100 && f.EmployeeCount <= 300).ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми, які знаходяться в Лондоні:");
            //firms.Where(f => f.Address == "London").ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми, у яких прізвище директора White:");
            //firms.Where(f => f.DirectorFullName.Split(' ').Last() == "White").ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми, які засновані більше двох років тому:");
            //firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2).ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми, з дня заснування яких минуло 123 дні:");
            //firms.Where(f => (DateTime.Now - f.FoundationDate).Days == 123).ToList().ForEach(f => f.PrintInfo());

            //Console.WriteLine("Фірми з прізвищем директора 'Black' та назвою, що містить 'White':");
            //firms.Where(f => f.DirectorFullName.Split(' ').Last() == "Black" && f.Name.Contains("White")).ToList().ForEach(f => f.PrintInfo());
            #endregion
            #region Task3
            #endregion
            #region Task4
            #endregion
        }
    }
}