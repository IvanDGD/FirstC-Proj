using FirstC_Proj.GenericCollectionHW;
using FirstC_Proj.GenericCollections;
using System;
using System.Collections.Generic;

namespace FirstC_Proj
{

    class Program
    {
        static void Main()
        {
            #region Task1
            //Console.WriteLine("Enter path to file");
            //string text = Console.ReadLine();

            //if (!File.Exists(text))
            //{
            //    Console.WriteLine("File does not exist.");
            //}
            //else
            //{
            //    using (StreamReader reader = new StreamReader(text))
            //    {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //}
            #endregion
            #region Task2
            //int[] array = new int[0];

            //while (true)
            //{
            //    Console.WriteLine("\n1. Enter array");
            //    Console.WriteLine("2. Save array to file");
            //    Console.WriteLine("3. Load array from file");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Choose: ");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            array = InputArray();
            //            break;
            //        case "2":
            //            SaveArrayToFile(array);
            //            break;
            //        case "3":
            //            array = LoadArrayFromFile();
            //            break;
            //        case "4":
            //            return;
            //        default:
            //            Console.WriteLine("Error");
            //            break;
            //    }
            //}
            #endregion
            #region Task3
            string evenFileName = "even_numbers.txt";
            string oddFileName = "odd_numbers.txt";
            Random random = new Random();

            using (StreamWriter evenWriter = new StreamWriter(evenFileName))
            using (StreamWriter oddWriter = new StreamWriter(oddFileName))
            {
                for (int i = 0; i < 10000; i++)
                {
                    int number = random.Next(int.MinValue, int.MaxValue);
                    if (number % 2 == 0)
                    {
                        evenWriter.WriteLine(number);
                    }
                    else
                    {
                        oddWriter.WriteLine(number);
                    }
                }
            }

            DisplayFileStatistics(evenFileName);
            DisplayFileStatistics(oddFileName);
            #endregion
        }
        static void DisplayFileStatistics(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileInfo fileInfo = new FileInfo(fileName);
                Console.WriteLine($"\nStatistics for file: {fileInfo.Name}");
                Console.WriteLine($"Path: {fileInfo.FullName}");
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                Console.WriteLine($"Last Access Time: {fileInfo.LastAccessTime}");
                Console.WriteLine($"Last Write Time: {fileInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist.");
            }
        }
        static int[] InputArray()
        {
            Console.Write("Enter array size: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Console.Write("Incorrect number, enter int: ");
                    }
                }
                return array;
            }
            Console.WriteLine("Incorrect array size.");
            return new int[0];
        }

        static void SaveArrayToFile(int[] array)
        {
            Console.Write("Enter name of file to save: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (int num in array)
                {
                    writer.Write(num);
                    writer.Write(" ");
                }
            }

            Console.WriteLine("Array was saved.");
        }

        static int[] LoadArrayFromFile()
        {
            Console.Write("Enter name of file to load: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("Error: file doesn't exist.");
                return new int[0];
            }

            string content = File.ReadAllText(filename);
            string[] parts = content.Split(' ');
            int count = 0;

            foreach (string part in parts)
            {
                if (part.Length > 0)
                {
                    count++;
                }
            }

            int[] array = new int[count];
            int index = 0;

            foreach (string part in parts)
            {
                if (part.Length > 0 && int.TryParse(part, out int number))
                {
                    array[index++] = number;
                }
            }

            Console.Write("Array loaded: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            return array;
        }
    }
}