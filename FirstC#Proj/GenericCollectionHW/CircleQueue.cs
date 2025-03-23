using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollectionHW
{
    internal class CircleQueue<T>
    { 
        private T[] array;
        private int head;
        private int tail;
        private int count;
        private int capacity;

        public int Count => count;
        public int Capacity => capacity;
        public bool IsEmpty => count == 0;
        public bool IsFull => count == capacity;

        public CircleQueue(int size)
        {
            capacity = size;
            array = new T[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull)
            {
                Console.WriteLine("Queue is full.");
            }

            array[tail] = item;
            tail = (tail + 1) % capacity;
            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty){
                Console.WriteLine("Queue is empty.");
            }

            T item = array[head];
            head = (head + 1) % capacity;
            count--;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty){
                Console.WriteLine("Queue is empty.");
            }
            return array[head];
        }
    }
}
