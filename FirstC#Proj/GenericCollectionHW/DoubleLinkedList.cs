using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollectionHW
{
    public class DoubleLinkedList<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;
            public Node Prev;

            public Node(T data)
            {
                Data = data;
                Next = null;
                Prev = null;
            }
        }

        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void Add(T item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            Count++;
        }

        public void AddLast(T item)
        {
            Node newNode = new Node(item);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            Count++;
        }

        public void Remove(T item)
        {

            Node current = head;
            while (current != null && !current.Data.Equals(item))
            {
                current = current.Next;
            }


            if (current.Prev != null)
            {
                current.Prev.Next = current.Next;
            }
            else
            {
                head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Prev = current.Prev;
            }
            else
            {
                tail = current.Prev;
            }

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
