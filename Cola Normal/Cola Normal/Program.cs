using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_Normal
{
    class Program
    {
        class Queue<T>
        {
            class Node
            {
                public T Value { get; set; }
                public Node Next { get; set; }
                public Node Previous { get; set; }
                public Node(T value)
                {
                    Value = value;
                    Next = null;
                    Previous = null;
                }
            }
            private Node Head { get; set; }
            private Node Tail { get; set; }
            private int length = 0;

            public void Enqueue(T value)
            {
                if (Head == null)
                {
                    Node newNode = new Node(value);
                    Head = newNode;
                    Tail = newNode;
                    Head.Next = newNode;
                    length = length + 1;
                }
                else
                {
                    Node newNode = new Node(value);
                    newNode.Previous = Tail;
                    Tail.Next = newNode;
                    Tail = newNode;
                    length = length + 1;
                }
            }

            public void Dequeue()
            {
                if (Head == null)
                {
                    throw new NullReferenceException("Esta vacio chico");
                }
                else
                {
                    Node oldHead = Head;
                    Node newHead = Head.Next;
                    Head.Next = null;
                    newHead.Previous = null;
                    Head = newHead;
                    oldHead = null;
                    length = length - 1;
                }
            }

            public void PrintAllNodes()
            {
                Node tmp = Head;
                while (tmp != null)
                {
                    Console.Write(tmp.Value + " ");
                    tmp = tmp.Next;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(9);
            queue.Enqueue(8);
            queue.PrintAllNodes();

            Console.WriteLine();

            queue.Dequeue();
            queue.Dequeue();
            queue.PrintAllNodes();
            Console.ReadLine();
        }
    }
}
