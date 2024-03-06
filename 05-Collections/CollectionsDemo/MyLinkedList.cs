using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class MyLinkedList
    {
        Node head;
        int count;
        public int Count { get => count; }
        public bool IsEmpty { get => count == 0; }
        public MyLinkedList()
        {
            count = 0;
            head = null;
        }

        public void Add(int index, object data)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Er du sikker? Index: " + index);
            }
            else if (index > count)
            {
                index = count;
            }

            Node current = head;
            if (IsEmpty || index == 0)
            {
                head = new Node(data, head);
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(data, current.Next);
            }
            count++;
        }
        public void Add(object data)
        {
            Add(count, data);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Er du sikker? Index: " + index);
            }
            if (IsEmpty)
            {
                Console.WriteLine("Nothing to Remove");
            }

            Node current = head;
            if (index == 0)
            {
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            count--;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
