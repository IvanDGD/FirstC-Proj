using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollectionHW
{
    internal class SingleLinkedList<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;
        public int Count { get; private set; }

        public void Add(T item)
        {
            Node newNode = new Node(item) { Next = head };
            head = newNode;
            Count++;
        }

        public void Remove(T item)
        {

            if (head.Data.Equals(item))
            {
                head = head.Next;
                Count--;
            }

            Node current = head;
            while (current.Next != null && !current.Next.Data.Equals(item))
            {
                current = current.Next;
            }


            current.Next = current.Next.Next;
            Count--;
        }

        public bool Contains(T item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }

        public void PrintAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
