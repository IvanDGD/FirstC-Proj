
using System.Text.Json;
using FirstC_Proj.Serialize;

namespace FirstC_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int size = 10;
            //int[] arr = new int[size];
            //bool isExit = false;
            //string choice2;

            //do
            //{
            //    Console.WriteLine("Menu:");
            //    Console.WriteLine("1. Enter an array of integers from the keyboard");
            //    Console.WriteLine("2. Filter numbers");
            //    Console.WriteLine("3. Serialize array");
            //    Console.WriteLine("4. Save serialized array to a file");
            //    Console.WriteLine("5. Load serialized array from a file");
            //    Console.WriteLine("6. Exit");
            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            InputArr(arr, size);
            //            break;
            //        case "2":
            //            Console.WriteLine("Filter by:");
            //            Console.WriteLine("1. Delete prime numbers");
            //            Console.WriteLine("2. Delete Fibonacci numbers");
            //            choice2 = Console.ReadLine();

            //            switch (choice2)
            //            {
            //                case "1":
            //                    arr = DeletePrime(arr);
            //                    break;
            //                case "2":
            //                    arr = DeleteFibonacci(arr);
            //                    break;
            //                default:
            //                    Console.WriteLine("Incorrect input.");
            //                    break;
            //            }
            //            break;
            //        case "3":
            //            SerializeArr(arr);
            //            break;
            //        case "4":
            //            SaveArrToFile(arr);
            //            break;
            //        case "5":
            //            arr = LoadArrFromFile();
            //            break;
            //        case "6":
            //            isExit = true;
            //            break;
            //        default:
            //            Console.WriteLine("Incorrect input.");
            //            break;
            //    }
            //} while (!isExit);
            #endregion
            #region Task 2, Task 3 
            MusicalAlbum album = new MusicalAlbum();
            bool isExit = false;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Enter album information");
                Console.WriteLine("2. Display album information");
                Console.WriteLine("3. Serialize album");
                Console.WriteLine("4. Save serialized album to file");
                Console.WriteLine("5. Load serialized album from file");
                Console.WriteLine("6. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        album.InputAlbum();
                        break;
                    case "2":
                        album.DisplayAlbum();
                        break;
                    case "3":
                        album.SerializeAlbum();
                        break;
                    case "4":
                        album.SaveAlbumToFile();
                        break;
                    case "5":
                        album.LoadAlbumFromFile();
                        break;
                    case "6":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }
            } while (!isExit);
            #endregion
            #region Task 4
            #endregion
        }

        static void InputArr(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input number {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static int[] DeletePrime(int[] arr)
        {
            List<int> filteredList = new List<int>();
            foreach (int num in arr)
            {
                if (!IsPrime(num))
                {
                    filteredList.Add(num);
                }
            }
            return filteredList.ToArray();
        }

        static int[] DeleteFibonacci(int[] arr)
        {
            List<int> filteredList = new List<int>();
            foreach (int num in arr)
            {
                if (!IsFibonacci(num))
                {
                    filteredList.Add(num);
                }
            }
            return filteredList.ToArray();
        }

        static void SerializeArr(int[] arr)
        {
            string jsonString = JsonSerializer.Serialize(arr);
            Console.WriteLine("Serialized array: " + jsonString);
        }

        static void SaveArrToFile(int[] arr)
        {
            string filePath = "serializedArray.json";
            string jsonString = JsonSerializer.Serialize(arr);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"Serialized array saved to {filePath}");
        }

        static int[] LoadArrFromFile()
        {
            string filePath = "serializedArray.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                int[] arr = JsonSerializer.Deserialize<int[]>(jsonString);
                Console.WriteLine("Array loaded from file:");
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                return arr;
            }
            else
            {
                Console.WriteLine("File not found.");
                return new int[0];
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static bool IsFibonacci(int number)
        {
            int a = 0, b = 1, temp;
            while (b < number)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            return b == number || number == 0;
        }
    }
}