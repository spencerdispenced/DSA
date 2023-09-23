namespace LLCSharp;
class Program
{
    static void Main(string[] args)
    {
        SingleLL ll = new SingleLL(5);
        ll.AddAtBeginning(4);
        ll.AddAtBeginning(3);
        ll.AddAtBeginning(2);
        ll.AddAtBeginning(1);
        ll.PrintList();

        int[] nums = {6, 7, 8, 9, 10};
        ll.AddMultipleAtEnd(nums);
        ll.PrintList();

        ll.AddAtEnd(11);
        ll.AddAtEnd(12);
        ll.PrintList();

        ll.InsertBeforeTargetValue(3, 5);
        ll.PrintList();

        ll.DeleteByValue(6);
        ll.PrintList();

        ll.Reverse();
        ll.PrintList();

        Console.WriteLine(ll.FindValue(1)); // true
        Console.WriteLine(ll.FindValue(100)); // false
    }
}
