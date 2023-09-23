using System;
using System.Collections.Generic;

#nullable enable
namespace LLCSharp
{
    public class Node
    {
        public int? Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data)
        {
           Data = data;
           Next = null;
        }

        public Node()
        {
            Data = null;
            Next = null;
        }
    }
}
  