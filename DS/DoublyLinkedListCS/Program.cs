namespace DoublyLinkedListCS;
class Program
{
    static void Main(string[] args)
    {
        var ll = new DoublyLinkedList();
        // ll.InsertAtHead(1);
        // ll.InsertAtHead(2);
        // ll.InsertAtHead(3);
        // ll.InsertAtHead(4);
        ll.InsertAtTail(5);
        // ll.InsertAtTail(6);
        // ll.InsertAtTail(7);
        ll.InsertAtHead(4);
        ll.InsertAtHead(1);
        ll.InsertAtTail(6);
        ll.PrintList();
    }
}
