using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoublyLinkedListCS
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        static int size = 0;

        public DoublyLinkedList()
        {
            Head = new Node();
            Tail = new Node();
            Head.Next = Tail;
            Tail.Prev = Head;
        }

        public void InsertAtHead(int data)
        {
            Node newNode = new Node(data);
            Node nextNode = Head.Next ?? Tail;

            newNode.Next = Head.Next;
            newNode.Prev = Head;  
            nextNode.Prev = newNode;
            Head.Next = newNode;
            size++;
        }

        public void InsertAtTail(int data)
        {
            Node newNode = new Node(data);
            Node prevNode = Tail.Prev ?? Head;

            newNode.Next = Tail;
            newNode.Prev = prevNode;
            prevNode.Next = newNode;
            Tail.Prev = newNode; 
        }

        public void PrintList()
        {
            Node? currentNode = Head.Next;
            if (currentNode != null)
            {
                while (currentNode.Next != null)
                {
                    Console.Write($"{currentNode.Data} -> ");
                    currentNode = currentNode.Next;
                }
            }
           
            Console.WriteLine();
        }
    }
}