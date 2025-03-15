using System;

namespace FirstC_Proj
{
    internal class Program
    {
        delegate string CheckEvenOdd(int number);
        delegate double PowerDelegate(double number, int exponent);
        delegate bool IsWeekendDelegate(string day);
        delegate (double maxValue, int index) MaxValueDelegate(double[] array);
        delegate (double minValue, int index) MinValueDelegate(double[] array);
        delegate int[] FilterOddNumbersDelegate(int[] array);

        static void Main(string[] args)
        {
            #region Task1
            //CheckEvenOdd checkEvenOdd = delegate (int number)
            //{
            //    return (number % 2 == 0) ? "double" : "odd";
            //};

            //int[] testNumbers = { 3, 10, 7, 8, 15, 22 };

            //foreach (var num in testNumbers)
            //{
            //    Console.WriteLine($"Number {num} is {checkEvenOdd(num)}");
            //}
            #endregion
            #region Task2
            //PowerDelegate power = delegate (double number, int exponent)
            //{
            //    double result = 1;
            //    for (int i = 0; i < exponent; i++)
            //    {
            //        result *= number;
            //    }
            //    return result;
            //};

            //double number = 3;
            //int exponent = 6;
            //Console.WriteLine($"{number} to the power of {exponent} = {power(number, exponent)}");

            #endregion
            #region Task3
            //PowerDelegate power = (number, exponent) =>
            //{
            //    double result = 1;
            //    for (int i = 0; i < exponent; i++)
            //    {
            //        result *= number;
            //    }
            //    return result;
            //};

            //double number = 3;
            //int exponent = 6;
            //Console.WriteLine($"{number} to the power of {exponent} = {power(number, exponent)}");
            #endregion
            #region Task4
            //IsWeekendDelegate isWeekend = day => day == "Saturday" || day == "Saturday";

            //string Saturday = "Saturday";
            //string Monday = "Monday";

            //Console.WriteLine($"{Saturday} is a weekend: {isWeekend(Saturday)}");
            //Console.WriteLine($"{Monday} is a weekend: {isWeekend(Monday)}");
            #endregion
            #region Task5
            //MaxValueDelegate findMaxValue = array =>
            //{
            //    double maxValue = array[0];
            //    int index = 0;

            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] > maxValue)
            //        {
            //            maxValue = array[i];
            //            index = i;
            //        }
            //    }
            //    return (maxValue, index);
            //};

            //double[] testArray = { 3.5, 7.2, 1.9, 9.4, 5.6 };
            //var (maxValue, maxIndex) = findMaxValue(testArray);

            //Console.WriteLine($"Maximum value in the array: {maxValue}");
            //Console.WriteLine($"Index of maximum value: {maxIndex}");
            #endregion
            #region Task6
            //MinValueDelegate findMinValue = array =>
            //{
            //    double minValue = array[0];
            //    int index = 0;

            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] < minValue)
            //        {
            //            minValue = array[i];
            //            index = i;
            //        }
            //    }
            //    return (minValue, index);
            //};

            //double[] testArray = { 3.5, 7.2, 1.9, 9.4, 5.6 };
            //var (minValue, minIndex) = findMinValue(testArray);

            //Console.WriteLine($"Maximum value in the array: {minValue}");
            //Console.WriteLine($"Index of minimum value: {minIndex}");
            #endregion
            #region Task7
            //FilterOddNumbersDelegate filterOddNumbers = array =>
            //{
            //    int count = 0;
            //    foreach (int num in array)
            //    {
            //        if (num % 2 != 0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] oddNumbers = new int[count];
            //    int index = 0;

            //    foreach (int num in array)
            //    {
            //        if (num % 2 != 0)
            //        {
            //            oddNumbers[index++] = num;
            //        }
            //    }

            //    return oddNumbers;
            //};

            //int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] oddNumbers = filterOddNumbers(testArray);

            //Console.WriteLine("Odd numbers in the array:");
            //foreach (int num in oddNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
        }
    }
}