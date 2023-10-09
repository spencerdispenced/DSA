using System;

namespace LinkedLists
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set;} = 0;

        public SinglyLinkedList()
        {
            Head = new Node
            {
                Next = null
            };
        }

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head.Next;
            Head.Next = newNode;
            Count++;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);

            Node currNode = Head;
            while (currNode.Next != null)
            {
                currNode = currNode.Next;
            }

            currNode.Next = newNode;

            Count++;
        }
        public void InsertMultipleAtEnd(int[] dataArray)
        {
            Node? currNode = Head;
            while (currNode.Next != null)
                currNode = currNode.Next;

            foreach (int num in dataArray)
            {
                Node newNode = new Node(num);
                currNode.Next = newNode;
                currNode = newNode;
            }
        }

        public void InsertBeforeValue(int target, int data)
        {
            Node newNode = new Node(data);

            Node currNode = Head;
            while (currNode.Next != null && currNode.Next.Data != target)
            {
                currNode = currNode.Next;
            }

            newNode.Next = currNode.Next;
            currNode.Next = newNode;
            Count++;
        }

        public void DeleteValue(int target)
        {
            Node currNode = Head;
            while (currNode.Next != null && currNode.Next.Data != target)
            {
                currNode = currNode.Next;
            }
            if (currNode.Next == null) // end of list, value not found
                return;

            currNode.Next = currNode.Next.Next;
            Count--;
        }

        public void Reverse()
        {
            Node? prevNode = null;
            Node? nextNode = null;
            Node? currNode = Head.Next;
            while (currNode != null)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            Head.Next = prevNode;
        }

        public List<int?> GetList()
        {
            List<int?> list = new();
            Node? currentNode = Head.Next;
            if (currentNode != null)
            {
                while (currentNode != null)
                {
                    list.Add(currentNode.Data);
                    currentNode = currentNode.Next;
                }
            }

            return list;
        }
    }
}