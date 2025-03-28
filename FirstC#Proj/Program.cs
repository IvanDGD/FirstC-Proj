using FirstC_Proj.GenericCollectionHW;
using FirstC_Proj.GenericCollections;
using FirstC_Proj.Lambda_Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FirstC_Proj
{

    class Program
    {
        delegate string GetColorRGB(string colorName);
        static int CountMultiples(int[] arr, int divisor, DCountMultiples countFunc)
        {
            return countFunc(arr, divisor);
        }
        
        delegate int DCountMultiples(int[] arr, int divisor);

        static int CountInRange(int[] arr, int min, int max)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num >= min && num <= max)
                {
                    count++;
                }
            }
            return count;
        }

        static void DisplayUniqueNegatives(int[] arr)
        {
            int[] uniqueNegatives = new int[arr.Length];
            int[] counts = new int[arr.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < uniqueCount; j++)
                    {
                        if (arr[i] == uniqueNegatives[j])
                        {
                            counts[j]++;
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        uniqueNegatives[uniqueCount] = arr[i];
                        counts[uniqueCount] = 1;
                        uniqueCount++;
                    }
                }
            }

            for (int i = 0; i < uniqueCount; i++)
            {
                if (counts[i] == 1)
                {
                    Console.Write($"{uniqueNegatives[i]} ");
                }
            }
            Console.WriteLine("");
        }

        static void Main()
        {
            #region Task1
            //GetColorRGB getRainbowColorRGB = delegate (string colorName)
            //{
            //    Color color = Color.FromName(colorName);
            //    if (color.IsKnownColor)
            //    {
            //        return $"{color.R},{color.G},{color.B}";
            //    }
            //    else
            //    {
            //        return "Incorrect color";
            //    }
            //};

            //string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            //foreach (string color in rainbowColors)
            //{
            //    Console.WriteLine($"{color}: {getRainbowColorRGB(color)}");
            //}
            #endregion
            #region Task2
            //Backpack myBackpack = new Backpack("Black", "Nike", "Polyester", 1.5, 20, 10);

            //myBackpack.ItemAdded += delegate (string item)
            //{
            //    Console.WriteLine($"Item added: {item}");
            //};

            //myBackpack.ItemRemoved += delegate (string item)
            //{
            //    Console.WriteLine($"Item removed: {item}");
            //};

            //myBackpack.CharacteristicsChanged += delegate (string message)
            //{
            //    Console.WriteLine(message);
            //};

            //try
            //{
            //    myBackpack.AddItem("Laptop", 5);
            //    myBackpack.AddItem("Water Bottle", 2);
            //    myBackpack.RemoveItem("Laptop", 5);
            //    myBackpack.ChangeCharacteristics("Red", "Adidas", "Nylon", 1.2, 25);
            //    myBackpack.AddItem("Tent", 30);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion
            #region Task3
            //int[] numbers = { 7, 14, 21, 28, 35, 42, 49, 50, 63, 70, 77, 84, 91, 100 };

            //DCountMultiples countMultiples = (arr, divisor) =>
            //{
            //    int count = 0;
            //    foreach (int num in arr)
            //    {
            //        if (num % divisor == 0)
            //            count++;
            //    }
            //    return count;
            //};

            //Console.WriteLine("Count of numbers divisible by 7: " + CountMultiples(numbers, 7, countMultiples));

            //Console.WriteLine("Count of numbers divisible by 5: " + CountMultiples(numbers, 5, countMultiples));
            //Console.WriteLine("Count of numbers divisible by 3: " + CountMultiples(numbers, 3, countMultiples));
            #endregion
            #region Task4
            //int[] numbers = { 3, 7, 15, 22, 30, 42, 50, 63, 77, 91 };

            //Console.WriteLine(CountInRange(numbers, 10, 50));
            //Console.WriteLine(CountInRange(numbers, 20, 80));
            //Console.WriteLine(CountInRange(numbers, 1, 100));
            #endregion
            #region Task5
            //int[] numbers = { -1, -2, -2, -3, -1, -4, -5, -5, 0, 1, 2, -6 };

            //DisplayUniqueNegatives(numbers);
            #endregion
            #region Task6
            //string text = "This is a test. This test is only a test.";
            //string wordToFind = "test";

            //int countOccurrences(string inputText, string word)
            //{
            //    int count = 0;
            //    int index = 0;

            //    while ((index = inputText.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            //    {
            //        count++;
            //        index += word.Length;
            //    }

            //    return count;
            //}

            //int occurrences = countOccurrences(text, wordToFind);
            //Console.WriteLine($"The word '{wordToFind}' occurs {occurrences} times in the text:\n{text}");
            #endregion
            #region Task7
            ATM atm = new ATM();
            atm.Start();
            #endregion
        }
    }
}