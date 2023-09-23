using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLCSharp
{
    public class SingleLL
    {
        private Node head;

        public SingleLL(int data)
        {
            head = new Node();
            head.Next = new Node(data);
        }

        public void AddAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head.Next;
            head.Next = newNode;
        }

        public void AddAtEnd(int data)
        {
            Node currentNode = head.Next;    
            while (currentNode.Next != null) 
                currentNode = currentNode.Next;

            Node newNode = new Node(data);
            currentNode.Next = newNode;
        }

         public void AddMultipleAtEnd(int[] dataArray)
        {
            Node currentNode = head.Next;    
            while (currentNode.Next != null) 
                currentNode = currentNode.Next;
              
            foreach (int num in dataArray)
            {
                Node newNode = new Node(num);
                currentNode.Next = newNode;
                currentNode = newNode;
            }
        }

        public void InsertBeforeTargetValue(int data, int target)
        {
            Node currentNode = head.Next;    
            while (currentNode.Next.Data != target) 
                currentNode = currentNode.Next;

            Node newNode = new Node(data);
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
        }

        public void DeleteByValue(int target)
        {
            Node currentNode = head.Next;    
            while (currentNode.Next.Data != target) 
                currentNode = currentNode.Next;

            currentNode.Next = currentNode.Next.Next;
        }

        public bool FindValue(int target)
        {
            Node currentNode = head.Next;
            while (currentNode != null)
            {
                if (currentNode.Data == target) return true;
                
                currentNode = currentNode.Next;
            }

            return false;
        }


        public void Reverse()
        {
            Node prev = null;
            Node next = null;
            Node curr = head.Next;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            head.Next = prev;
        }

        public void PrintList()
        {
            Node currentNode = head.Next;
            while (currentNode != null)
            {
                Console.Write($"{currentNode.Data} -> ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}