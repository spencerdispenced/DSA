namespace LinkedListsTests;

public class SinglyLinkedListTests
{
    [Fact]
    public void SinglyLinkedList_InsertAtBeginning()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expected = new List<int?>(){1, 14, 3, 2, 1};

        ll.InsertAtBeginning(1);
        ll.InsertAtBeginning(2);
        ll.InsertAtBeginning(3);
        ll.InsertAtBeginning(14);
        ll.InsertAtBeginning(1);
        var result = ll.GetList();

        result.Should().Equal(expected);
    }

    [Fact]
    public void SinglyLinkedList_InsertAtEnd()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expected = new List<int?>(){1, 2, 3, 4};

        ll.InsertAtEnd(1);
        ll.InsertAtEnd(2);
        ll.InsertAtEnd(3);
        ll.InsertAtEnd(4);
       
        var result = ll.GetList();

        result.Should().Equal(expected);
    }

    [Fact]
    public void SinglyLinkedList_InsertAtBothEnds()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expected = new List<int?>(){0, 10, 5, 20, 22};

        ll.InsertAtBeginning(5);
        ll.InsertAtBeginning(10);
        ll.InsertAtEnd(20);
        ll.InsertAtEnd(22);
        ll.InsertAtBeginning(0);
        var result = ll.GetList();

        result.Should().Equal(expected);
    }

    [Fact]
    public void SinglyLinkedList_InsertBeforeValue()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expected = new List<int?>(){10, 5, 100, 20, 22};

        ll.InsertAtBeginning(5);
        ll.InsertAtBeginning(10);
        ll.InsertAtEnd(20);
        ll.InsertAtEnd(22);
        ll.InsertBeforeValue(20, 100);
        var result = ll.GetList();

        result.Should().Equal(expected);
    }

    [Fact]
    public void SinglyLinkedList_InsertMultiple()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expectedBefore = new List<int?>(){1,2,3};
        List<int?> expectedAfter = new List<int?>(){1,2,3,4,5,6};

        ll.InsertAtEnd(1);
        ll.InsertAtEnd(2);
        ll.InsertAtEnd(3);
        
        var result = ll.GetList();

        result.Should().Equal(expectedBefore);

        ll.InsertMultipleAtEnd(new int[] {4,5,6});
        result = ll.GetList();

        result.Should().Equal(expectedAfter);
    }

    [Fact]
    public void SinglyLinkedList_DeleteValue()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expectedBeforeDelete = new List<int?>(){1, 2, 3, 4, 5};
        List<int?> expectedAfterDelete = new List<int?>(){1, 2, 4, 5};

        ll.InsertAtEnd(1);
        ll.InsertAtEnd(2);
        ll.InsertAtEnd(3);
        ll.InsertAtEnd(4);
        ll.InsertAtEnd(5);
        
        var result = ll.GetList();

        result.Should().Equal(expectedBeforeDelete);

        ll.DeleteValue(3);
        result = ll.GetList();

        result.Should().Equal(expectedAfterDelete);
    }

    [Fact]
    public void SinglyLinkedList_ReverseList()
    {
        SinglyLinkedList ll = new SinglyLinkedList();
        List<int?> expectedBeforeDelete = new List<int?>(){1, 2, 3, 4, 5};
        List<int?> expectedAfterDelete = new List<int?>(){5, 4, 3, 2, 1};

        ll.InsertAtEnd(1);
        ll.InsertAtEnd(2);
        ll.InsertAtEnd(3);
        ll.InsertAtEnd(4);
        ll.InsertAtEnd(5);
        
        var result = ll.GetList();

        result.Should().Equal(expectedBeforeDelete);

        ll.Reverse();
        result = ll.GetList();

        result.Should().Equal(expectedAfterDelete);
    }
}