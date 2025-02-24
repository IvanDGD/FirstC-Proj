using System;
using System.Globalization;
using System.Text;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //float[] A = new float[5];

            //int rows = 3;
            //int cols = 4;

            //float[,] B = new float[rows, cols];

            //Random rnd = new Random();

            //Console.WriteLine("Enter num for A array:");
            //InitArray(A);
            //InitMultiArray(B, rows, cols, rnd);

            //Console.WriteLine("Array A:");
            //PrintArray(A);
            //Console.WriteLine("Array B:");
            //PrintMultiArray(B, rows, cols);

            //float max = FindMax(A, B, rows, cols);
            //float min = FindMin(A, B, rows, cols);
            //float totalSum = CalculateTotalSum(A, B, rows, cols);
            //float totalProduct = CalculateTotalProduct(A, B, rows, cols);
            //float evenSumA = CalculateEvenSumA(A);
            //float oddColumnSumB = CalculateOddColumnSumB(B, rows, cols);

            //Console.WriteLine($"Max Element: {max}");
            //Console.WriteLine($"Min Element: {min}");
            //Console.WriteLine($"Total Sum: {totalSum}");
            //Console.WriteLine($"Total Product: {totalProduct}");
            //Console.WriteLine($"Sum of Even Elements in A: {evenSumA}");
            //Console.WriteLine($"Sum of Odd Columns in B: {oddColumnSumB}");
            #endregion

            #region Task2

            //int rows = 5;
            //int cols = 5;

            //int[,] array = new int[rows, cols];

            //Random rnd = new Random();

            //InitMultiArray(array, rows, cols, rnd);

            //PrintMultiArray(array, rows, cols);

            //int minValue = array[0, 0];
            //int maxValue = array[0, 0];
            //int minRow = 0, minCol = 0;
            //int maxRow = 0, maxCol = 0;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        if (array[i, j] < minValue)
            //        {
            //            minValue = array[i, j];
            //            minRow = i;
            //            minCol = j;
            //        }
            //        if (array[i, j] > maxValue)
            //        {
            //            maxValue = array[i, j];
            //            maxRow = i;
            //            maxCol = j;
            //        }
            //    }
            //}

            //int sum = 0;
            //bool isBetween = false;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        if ((i == minRow && j == minCol) || (i == maxRow && j == maxCol))
            //        {
            //            if (isBetween)
            //            {
            //                break;
            //            }
            //            isBetween = true;
            //        }

            //        if (isBetween)
            //        {
            //            sum += array[i, j];
            //        }
            //    }
            //    if (isBetween && (i == maxRow || i == minRow))
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sum}");


            #endregion

            #region Task3

            //Console.Write("Enter string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter shift: ");
            //int shift = int.Parse(Console.ReadLine());

            //string encrypted = Encrypt(input, shift);
            //Console.WriteLine("Encrypted: " + encrypted);

            //string decrypted = Decrypt(encrypted, shift);
            //Console.WriteLine("Decrypted: " + decrypted);

            #endregion

            #region Task4

            //int rows = 3;
            //int cols = 4;
            //int[,] A = new int[rows, cols];

            //int[,] B = new int[rows, cols];

            //Random rnd = new Random();

            //Console.WriteLine("Array A:");
            //InitMultiArrayLowerRange(A, rows, cols, rnd);
            //PrintMultiArray(A, rows, cols);

            //Console.WriteLine("Array B:");
            //InitMultiArrayLowerRange(B, rows, cols, rnd);
            //PrintMultiArray(B, rows, cols);

            //Console.Write("Enter produt value: ");
            //int value = int.Parse(Console.ReadLine());

            //MatrixValueProduct(B, rows, cols, value);
            //Console.WriteLine("Array B:");
            //PrintMultiArray(B, rows, cols);

            //int[,] C = MatrixPlus(A, B, rows, cols);
            //Console.WriteLine("Array C:");
            //PrintMultiArray(C, rows, cols);

            //int[,] D = MatrixProduct(A, B, rows, cols);
            //Console.WriteLine("Array D:");
            //PrintMultiArray(D, rows, cols);

            #endregion

            #region Task5

            //Console.Write("Enter arefmetical (+ or -): ");
            //string input = Console.ReadLine();

            //Console.Write("Enter first num: ");
            //int value1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second num: ");
            //int value2 = int.Parse(Console.ReadLine());

            //int result = EvaluateExpression(input, value1, value2);
            //Console.WriteLine("Result: " + result);

            #endregion

            #region Task6

            //Console.Write("Enter string: ");
            //string input = Console.ReadLine();

            //string capitalizedText = CapitalizeSentences(input);
            //Console.WriteLine("Result: " + capitalizedText);

            #endregion

            #region Task7

            //Console.Write("Enter string: ");
            //string input = Console.ReadLine();

            //string filteredText = MuteWords(input);

            //Console.WriteLine("Result:");
            //Console.WriteLine(filteredText);

            #endregion

            #region Task8

            //Console.Write("Enter string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter shift: ");
            //int shift = int.Parse(Console.ReadLine());

            //string encrypted = Encrypt(input, shift);
            //Console.WriteLine("Encrypted: " + encrypted);

            #endregion

            #region Task9

            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter cols: ");
            int cols = int.Parse(Console.ReadLine());

            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            GenerateAndMultiplyArray(rows, cols, value);

            #endregion

        }


        static void GenerateAndMultiplyArray(int rows, int cols, int value)
        {
            int[,] matrix = new int[rows, cols];
            Random rnd = new Random();

            InitMultiArray(matrix, rows, cols, rnd);

            MatrixValueProduct(matrix, rows, cols, value);

            PrintMultiArray(matrix, rows, cols);
        }

        static string MuteWords(string text)
        {
            string wordForMute = "die";
            string replacement = "***";
            int count = 0;

            int index = 0;
            while (true)
            {
                index = text.IndexOf(wordForMute, index, StringComparison.OrdinalIgnoreCase);

                if (index == -1)
                    break;

                bool isWholeWord = true;

                if (index > 0 && char.IsLetterOrDigit(text[index - 1]))
                    isWholeWord = false;

                if (index + wordForMute.Length < text.Length && char.IsLetterOrDigit(text[index + wordForMute.Length]))
                    isWholeWord = false;

                if (isWholeWord)
                {
                    text = text.Remove(index, wordForMute.Length).Insert(index, replacement);
                    index += replacement.Length;
                    count++;
                }
                else
                {
                    index += wordForMute.Length;
                }
            }

            Console.WriteLine($"Statistic: {count} replaced words {wordForMute}");

            return text;
        }

        static string CapitalizeSentences(string text)
        {
            StringBuilder result = new StringBuilder(text.Length);
            bool capitalizeNext = true;

            foreach (char ch in text)
            {
                if (capitalizeNext && char.IsLetter(ch))
                {
                    result.Append(char.ToUpper(ch));
                    capitalizeNext = false;
                }
                else
                {
                    result.Append(ch);
                }

                if (ch == '.' || ch == '!' || ch == '?')
                {
                    capitalizeNext = true;
                }
            }

            return result.ToString();
        }

        static int EvaluateExpression(string expression, int value1, int value2)
        {
            int result = 0;
            
            char ch = expression[0];

            if (!char.IsDigit(ch) && !char.IsWhiteSpace(ch) || 0 == expression.Length - 1)
            {
                if (ch == '+')
                {
                    result = value1 + value2;
                }
                else if (ch == '-')
                {
                    result = value1 - value2;
                }
            }
            return result;
        }

        static int[,] MatrixProduct(int[,] arr, int[,] arr2, int rows, int cols)
        {
            int[,] arr3 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr3[i, j] = arr[i, j] * arr2[i, j];
                }
            }

            return arr3;

        }

        static int[,] MatrixPlus(int[,] arr, int[,] arr2, int rows, int cols)
        {
            int[,] arr3 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr3[i, j] = arr[i, j] + arr2[i, j];
                }
            }

            return arr3;

        }

        static void MatrixValueProduct(int[,] arr, int rows, int cols, int value)
        {
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        arr[i, j] *= value;
                    }
                }
            }
        }

        static string Encrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char baseChar = char.IsUpper(letter) ? 'A' : 'a';
                    buffer[i] = (char)((letter - baseChar + shift) % 26 + baseChar);
                }
            }

            return new string(buffer);
        }

        static string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - (shift % 26));
        }

        static void InitMultiArray(int[,] arr, int rows, int cols, Random rnd)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int randomNum = rnd.Next(-100, 101);

                    arr[i, j] = randomNum;
                }
            }
        }

        static void InitMultiArrayLowerRange(int[,] arr, int rows, int cols, Random rnd)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int randomNum = rnd.Next(1, 11);

                    arr[i, j] = randomNum;
                }
            }
        }
        static void InitMultiArray(float[,] arr, int rows, int cols,  Random rnd)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    float randomNum = 1 + (float)rnd.NextDouble() * 99;

                    arr[i, j] = randomNum;
                }
            }
        }
        static void InitArray(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                float value = float.Parse(Console.ReadLine());
                arr[i] = value;
            }
        }

        static void PrintArray(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n");
        }
        static void PrintMultiArray(int[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void PrintMultiArray(float[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        static float FindMax(float[] A, float[,] B, int rows, int cols)
        {
            float max = A[0];
            foreach (var num in A)
            {
                if (num > max) max = num;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (B[i, j] > max) max = B[i, j];
                }
            }
            return max;
        }

        static float FindMin(float[] A, float[,] B, int rows, int cols)
        {
            float min = A[0];
            foreach (var num in A)
            {
                if (num < min) min = num;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (B[i, j] < min) min = B[i, j];
                }
            }
            return min;
        }

        static float CalculateTotalSum(float[] A, float[,] B, int rows, int cols)
        {
            float sum = 0;
            foreach (var num in A) sum += num;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    sum += B[i, j];

            return sum;
        }

        static float CalculateTotalProduct(float[] A, float[,] B, int rows, int cols)
        {
            float product = 1;
            foreach (var num in A) product *= num;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    product *= B[i, j];

            return product;
        }

        static float CalculateEvenSumA(float[] A)
        {
            float sum = 0;
            foreach (var num in A)
            {
                if (((int)num % 2) == 0) sum += num;
            }
            return sum;
        }

        static float CalculateOddColumnSumB(float[,] B, int rows, int cols)
        {
            float sum = 0;
            for (int j = 1; j < cols; j += 2) 
            {
                for (int i = 0; i < rows; i++)
                {
                    sum += B[i, j];
                }
            }
            return sum;
        }

    }
}
