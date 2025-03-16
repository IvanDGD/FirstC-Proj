using System;

namespace FirstC_Proj
{

    class Program
    {
        static T Max<T>(T[] arr) where T : IComparable<T>
        {
            T maxNum = arr[0];

            foreach (T item in arr)
            {
                if (item.CompareTo(maxNum) > 0)
                {
                    maxNum = item;
                }
            }

            return maxNum;
        }

        public class Stack<T>
        {
            private T[] arr;
            private int size;
            private int _capacity;

            public Stack(int capacity = 10)
            {
                _capacity = capacity;
                arr = new T[capacity];
                size = 0;
            }

            public void Push(T item)
            {
                if (size == _capacity)
                {
                    Resize();
                }
                arr[size++] = item;
            }

            public T Pop()
            {
                T item = arr[--size];
                arr[size] = default;
                return item;
            }

            public T Peek()
            {
                return arr[size - 1];
            }

            public int Count => size;

            private void Resize()
            {
                _capacity *= 2;
                Array.Resize(ref arr, _capacity);
            }
        }

        static void Main(string[] args)
        {
            #region Task1
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Max: " + Max(numbers));
            #endregion
            #region Task2
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Top element: " + stack.Peek());
            Console.WriteLine("Popped: " + stack.Pop()); 
            Console.WriteLine("Count: " + stack.Count);
            #endregion
        }
    }
}