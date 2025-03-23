using FirstC_Proj.GenericCollectionHW;
using FirstC_Proj.GenericCollections;
using System;
using System.Collections.Generic;

namespace FirstC_Proj
{

    class Program
    {

        static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            #region Task1
            //int num1 = 10;
            //int num2 = 20;
            //Swap(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //string str1 = "asdf";
            //string str2 = "abc";
            //Swap(ref str1, ref str2);
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            #endregion
            #region Task2
            //PriorityQueue<int> pq = new PriorityQueue<int>();

            //pq.Enqueue(5);
            //pq.Enqueue(2);
            //pq.Enqueue(8);
            //pq.Enqueue(1);

            //Console.WriteLine("Priority Queue:");

            //while (pq.Count > 0)
            //{
            //    Console.WriteLine(pq.Dequeue());
            //}
            #endregion
            #region Task3
            //CircleQueue<int> cq = new CircleQueue<int>(4);

            //cq.Enqueue(5);
            //cq.Enqueue(2);
            //cq.Enqueue(8);
            //cq.Enqueue(1);

            //Console.WriteLine("Circle Queue:");

            //while (cq.Count > 0)
            //{
            //    Console.WriteLine(cq.Dequeue());
            //}
            #endregion
            #region Task4
            //SingleLinkedList<int> list = new SingleLinkedList<int>();

            //list.Add(5);
            //list.Add(2);
            //list.Add(8);
            //list.Add(1);
            //list.PrintAll();
            //list.Remove(5);
            //list.PrintAll();
            #endregion
            #region Task5
            //DoubleLinkedList<int> list = new DoubleLinkedList<int>();

            //list.Add(5);
            //list.Add(2);
            //list.Add(8);
            //list.Add(1);
            //list.PrintAll();
            //list.Remove(2);
            //list.PrintAll();
            #endregion
            #region Task6
            List<int> numbersOdd = new List<int> { 5, 2, 9, 1, 6 };
            Console.WriteLine($"Median of numbersOdd: {FindMedian(numbersOdd)}");

            List<string> wordsOdd = new List<string> { "apple", "banana", "cherry", "date", "fig" };
            Console.WriteLine($"Median of wordsOdd: {FindMedian(wordsOdd)}");

            List<float> numbersEven = new List<float> { 4, 1, 7, 9, 3, 8 };
            Console.WriteLine($"Median of numbersEven: {FindMedian(numbersEven)}");

            List<string> wordsEven = new List<string> { "apple", "banana", "cherry", "date" };
            Console.WriteLine($"Median of wordsEven: {FindMedian(wordsEven)}");

            List<int> emptyList = new List<int>();
            Console.WriteLine($"Median of empty list: {FindMedian(emptyList)}");
            #endregion
        }

        static T FindMedian<T>(IList<T> collection) where T : IComparable<T>
        {
            if (collection == null || collection.Count == 0)
            {
                Console.WriteLine("Collection cannot be empty");
                return default;
            }

            List<T> sortedList = new List<T>(collection);
            sortedList.Sort();

            int count = sortedList.Count;
            int mid = count / 2;

            if (count % 2 == 1)
            {
                return sortedList[mid];
            }
            else
            {
                if (typeof(T) == typeof(string))
                {
                    return sortedList[mid - 1];
                }
                else
                {
                    dynamic first = sortedList[mid - 1];
                    dynamic second = sortedList[mid];
                    return (first + second) / 2;
                }
            }
        }
    }
}