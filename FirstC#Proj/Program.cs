using FirstC_Proj.GenericCollectionHW;
using FirstC_Proj.GenericCollections;
using FirstC_Proj.Lambda_Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using FirstC_Proj.LINQ;

namespace FirstC_Proj
{

    class Program
    {

        static void Main()
        {
            #region Task1
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //Console.Write("Enter num: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter start range: ");
            //int startRange = int.Parse(Console.ReadLine());
            //Console.Write("Enter end range: ");
            //int endRange = int.Parse(Console.ReadLine());

            //var fullArrInts =
            //    from i in ints
            //    select i;

            //var doublesInArr =
            //    from d in ints
            //    where d % 2 == 0
            //    select d;

            //var oddInArr =
            //    from o in ints
            //    where o % 2 != 0
            //    select o;

            //var biggerNum =
            //    from biggerInt in ints
            //    where biggerInt > num1
            //    select biggerInt;

            //List<int> numbersInRange = new List<int>();

            //foreach (int number in ints)
            //{
            //    if (number >= startRange && number <= endRange)
            //    {
            //        numbersInRange.Add(number);
            //    }
            //}

            //var numbersMultiplesSeven =
            //    from multipleNum in ints
            //    where multipleNum % 7 == 0
            //    orderby multipleNum
            //    select multipleNum;

            //var numbersMultiplesEight =
            //    from multipleNum in ints
            //    where multipleNum % 8 == 0
            //    orderby multipleNum descending
            //    select multipleNum;

            //Console.WriteLine("Full array");
            //foreach (var item in fullArrInts)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Doubles in array");
            //foreach (var item in doublesInArr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Odd in array");
            //foreach (var item in oddInArr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Numbers bigger then num");
            //foreach (var item in biggerNum)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Numbers in your range");
            //foreach (var item in numbersInRange)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Multiples of seven");
            //foreach (var item in numbersMultiplesSeven)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Multiples of eight");
            //foreach (var item in numbersMultiplesEight)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            #endregion
            #region Task2
            //string[] cities = { "New York", "Amsterdam", "Oslo", "Berlin", "Newark", "Athens", "Nice", "Naples", "Nuremberg" };

            //Console.WriteLine("All cities:");
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //Console.WriteLine("\nCities with a specified length (6):");

            //var citiesLength = cities.Where(city => city.Length == 6);

            //foreach (string city in citiesLength)
            //{
            //    Console.WriteLine(city);
            //}
            //var startWithA = cities.Where(city => city.StartsWith("A"));
            //Console.WriteLine("\nCities starting with 'A':");
            //foreach (string city in startWithA)
            //{
            //    Console.WriteLine(city);
            //}
            //var endWithM = cities.Where(city => city.EndsWith("m"));
            //Console.WriteLine("\nCities ending with 'M':");
            //foreach (string city in endWithM)
            //{
            //    Console.WriteLine(city);
            //}
            //var startWithNEndWithK = cities.Where(city => city.StartsWith("N") && city.EndsWith("k"));
            //Console.WriteLine("\nCities starting with 'N' and ending with 'K':");
            //foreach (string city in startWithNEndWithK)
            //{
            //    Console.WriteLine(city);
            //}

            //var startWithNe = cities.Where(city => city.StartsWith("Ne")).ToArray();
            //Console.WriteLine("\nCities starting with 'Ne':");
            //string[] filteredCities = startWithNe;

            //for (int i = 0; i < filteredCities.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < filteredCities.Length; j++)
            //    {
            //        if (string.Compare(filteredCities[i], filteredCities[j]) < 0)
            //        {
            //            string temp = filteredCities[i];
            //            filteredCities[i] = filteredCities[j];
            //            filteredCities[j] = temp;
            //        }
            //    }
            //}

            //foreach (string city in filteredCities)
            //{
            //    Console.WriteLine(city);
            //}
            #endregion
            #region Task3
            //Student[] students =
            //{
            //    new Student("Boris", "Ivanov", 20, "Harvard"),
            //    new Student("Alice", "Brown", 22, "MIT"),
            //    new Student("Boris", "Petrov", 18, "Oxford"),
            //    new Student("John", "Brooks", 21, "Stanford"),
            //    new Student("Emily", "Bronson", 19, "Cambridge"),
            //    new Student("Michael", "Smith", 25, "Oxford"),
            //    new Student("Sarah", "Brody", 23, "MIT")
            //};

            //Console.WriteLine("All students:");
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //var nameBoris = students.Where(student => student.FirstName == "Boris");
            //Console.WriteLine("\nStudents named Boris:");
            //foreach (Student student in nameBoris)
            //{
            //    Console.WriteLine(student);
            //}
            //var lastNameStartWithBro = students.Where(student => student.LastName.StartsWith("Bro"));
            //Console.WriteLine("\nStudents with last name starting with 'Bro':");
            //foreach (Student student in lastNameStartWithBro)
            //{
            //    Console.WriteLine(student);
            //}
            //var olderThan19 = students.Where(student => student.Age > 19);
            //Console.WriteLine("\nStudents older than 19:");
            //foreach (Student student in olderThan19)
            //{
            //    Console.WriteLine(student);
            //}
            //var olderThan20YoungerThan23 = students.Where(student => student.Age > 20 && student.Age < 23);
            //Console.WriteLine("\nStudents older than 20 and younger than 23:");
            //foreach (Student student in olderThan20YoungerThan23)
            //{
            //    Console.WriteLine(student);
            //}
            //var studyingAtMIT = students.Where(student => student.University == "MIT");
            //Console.WriteLine("\nStudents studying at MIT:");
            //foreach (Student student in studyingAtMIT)
            //{
            //    Console.WriteLine(student);
            //}
            //var studyingAtOxfordOlderThan18 = students.Where(student => student.University == "Oxford" && student.Age > 18).ToArray();
            //Console.WriteLine("\nStudents studying at Oxford and older than 18:");
            //Student[] filteredStudents = studyingAtOxfordOlderThan18;

            //for (int i = 0; i < filteredStudents.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < filteredStudents.Length; j++)
            //    {
            //        if (filteredStudents[i].Age < filteredStudents[j].Age)
            //        {
            //            Student temp = filteredStudents[i];
            //            filteredStudents[i] = filteredStudents[j];
            //            filteredStudents[j] = temp;
            //        }
            //    }
            //}

            //foreach (Student student in filteredStudents)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion
            #region Task4
            string[] words = { "apple", "banana", "kiwi", "strawberry", "grape", "blueberry" };

            Console.WriteLine("Sorting by length");
            var sortedWord =
                from word in words
                orderby word.Length
                select word;
            foreach (string word in sortedWord)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nSorting by length descending");
            var sortedWordDescending =
                from word in words
                orderby word.Length descending
                select word;
            foreach (string word in sortedWordDescending)
            {
                Console.WriteLine(word);
            }
            #endregion
        }
    }
}