using System.Text.Json;
using FirstC_Proj.LINQ;

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
        public static int GetDigitSum(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        public static void SortByDigitSum(int[] array, bool descending)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    int sum1 = GetDigitSum(array[j]);
                    int sum2 = GetDigitSum(array[j + 1]);

                    bool needSwap = descending ? sum1 < sum2 : sum1 > sum2;

                    if (needSwap)
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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
            //List<Firm> firms = new List<Firm>
            //{
            //    new Firm
            //    {
            //        Name = "WhiteFood",
            //        FoundationDate = DateTime.Now.AddYears(-3),
            //        BusinessProfile = "Food",
            //        DirectorFullName = "John White",
            //        Address = "London",
            //        Employees = new List<LINQ.Employee>
            //        {
            //            new LINQ.Employee { FullName = "Alice Brown", Position = "Manager", PhoneNumber = "234567890", Email = "alice@whitefood.com", Salary = 5000 },
            //            new LINQ.Employee { FullName = "Lionel Messi", Position = "Chef", PhoneNumber = "237654321", Email = "lionel@whitefood.com", Salary = 4000 }
            //        }
            //    },
            //    new Firm
            //    {
            //        Name = "Black&White",
            //        FoundationDate = DateTime.Now.AddDays(-123),
            //        BusinessProfile = "IT",
            //        DirectorFullName = "Steve Black",
            //        Address = "Manchester",
            //        Employees = new List<LINQ.Employee>
            //        {
            //            new LINQ.Employee { FullName = "Diana White", Position = "Developer", PhoneNumber = "239876543", Email = "di.white@bw.com", Salary = 6000 },
            //            new LINQ.Employee { FullName = "Lionel Anderson", Position = "Manager", PhoneNumber = "230012345", Email = "lionel.anderson@bw.com", Salary = 5500 }
            //        }
            //    }
            //};

            //Console.WriteLine("Всі фірми:");
            //firms.ForEach(f => f.PrintInfo());

            //Console.WriteLine("Отримати всіх співробітників конкретної фірми (WhiteFood):");
            //firms.First(f => f.Name == "WhiteFood").Employees.ForEach(e => e.PrintInfo());

            //Console.WriteLine("Отримати всіх співробітників конкретної фірми (WhiteFood), у яких зарплата більша за 4500:");
            //firms.First(f => f.Name == "WhiteFood").Employees.Where(e => e.Salary > 4500).ToList().ForEach(e => e.PrintInfo());

            //Console.WriteLine("Отримати співробітників усіх фірм, у яких посада 'Manager':");
            //firms.SelectMany(f => f.Employees).Where(e => e.Position == "Manager").ToList().ForEach(e => e.PrintInfo());

            //Console.WriteLine("Отримати співробітників, у яких телефон починається з 23:");
            //firms.SelectMany(f => f.Employees).Where(e => e.PhoneNumber.StartsWith("23")).ToList().ForEach(e => e.PrintInfo());

            //Console.WriteLine("Отримати співробітників, у яких Email починається з 'di':");
            //firms.SelectMany(f => f.Employees).Where(e => e.Email.StartsWith("di")).ToList().ForEach(e => e.PrintInfo());

            //Console.WriteLine("Отримати співробітників, у яких ім'я 'Lionel':");
            //firms.SelectMany(f => f.Employees).Where(e => e.FullName.Split(' ')[0] == "Lionel").ToList().ForEach(e => e.PrintInfo());
            #endregion
            #region Task4
            int[] numbers = { 121, 75, 81 };

            Console.WriteLine("Оригінальний масив:");
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();
            
            SortByDigitSum(numbers, true);

            Console.WriteLine("Сортування за спаданням суми цифр:");
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();

            SortByDigitSum(numbers, false);

            Console.WriteLine("Сортування за зростанням суми цифр:");
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();
            #endregion
        }
    }
}