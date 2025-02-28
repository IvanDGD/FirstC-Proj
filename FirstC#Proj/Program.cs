using System;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            //SquarePrint(5, 9, "*");

            #endregion

            #region Task 2

            //if (IsPalindrome())
            //{
            //    Console.WriteLine("Your number is polindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Your number isn't polindrome");
            //}

            #endregion

            #region Task 3

            //int size = 7;
            //int[] array = new int[]{ 1, 2, 6, -1, 88, 7, 6, };

            //int[] arrayForFilter = {6, 88, 7 };

            //int[] filtredArray = FilterArray(array, arrayForFilter, size);

            //for(int i = 0; i < filtredArray.Length; i++)
            //{
            //    Console.Write($"{filtredArray[i]} ");
            //}

            #endregion

            #region Task 4

            //Website website = new Website("republiquedesmangues", "http://www.republiquedesmangues.fr", "Go to the site, it is very important", "217.160.0.38");

            //Website website2 = new Website();

            //website2.InputData();

            //website.DisplayData();
            //website2.DisplayData();

            #endregion

            #region Task 5

            //Magazine magazine = new Magazine();

            //magazine.InputData();
            //magazine.DisplayData();

            #endregion

            #region Task 6

            //Shop shop = new Shop();

            //shop.InputData();
            //shop.DisplayData();

            #endregion

            #region Task 7

            //Vessel vessel1 = new Vessel(100);
            //Vessel vessel2 = new Vessel(200, "Steel");
            //Vessel vessel3 = new Vessel(300, "Aluminum", true);

            //vessel1.PrintInfo();
            //vessel2.PrintInfo();
            //vessel3.PrintInfo();


            //vessel1.Fill(50);
            //vessel1.Fill(60);
            //vessel1.Empty(30);
            //vessel1.Empty(90);

            //vessel2.Fill(150);
            //vessel2.Empty(100);

            //vessel3.Empty(100);
            //vessel3.Fill(50);

            #endregion

        }

        static int[] FilterArray(int[] array, int[] arrayForFilter, int size)
        {
            int newSize = size;

            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < arrayForFilter.Length; j++)
                {
                    if (array[i] == arrayForFilter[j])
                    {
                        newSize--;

                        for (int k = i; k < newSize; k++)
                        {
                            array[k] = array[k + 1];
                        }

                        i--;
                        break;
                    }
                }
            }

            int[] result = new int[newSize];
            for (int i = 0; i < newSize; i++)
            {
                result[i] = array[i];
            }

            return result;
        }

        static bool IsPalindrome()
        {
            Console.Write("Enter number: ");
            string str = Console.ReadLine();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }

            return true;

        }

        static void SquarePrint(int height, int width, string symbol)
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(symbol);
                    }
                }
                else 
                {
                    Console.Write(symbol);
                    for (int j = 1; j < width - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    if (width > 1) Console.Write(symbol); 
                }
                Console.WriteLine();
            }
        }


    }
}
