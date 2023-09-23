using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoublyLinkedListCS
{
    public class Node
    {
        public int? Data { get; set; }
        public Node? Next { get; set; }
        public Node? Prev { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public Node() {}
    }
}