# ShouldlyExtension.Aggregate
The ShouldlyExtension.Aggregates library is a C# library that provides extension methods for the Shouldly assertion library. 
It is designed to simplify the process of testing collections in unit tests.

The library contains four extension methods that allow you to test whether the first or last item in a collection is equivalent to a given object. These methods include:
ShouldBeEquivalentToLastItem: This method asserts that the last item in the collection is equivalent to a given object.

ShouldBeEquivalentToLastItem<TInput, TKey>: This method asserts that the last item in the collection, after being sorted by a key, is equivalent to a given object.

ShouldBeEquivalentToFirstItem: This method asserts that the first item in the collection is equivalent to a given object.

ShouldBeEquivalentToFirstItem<TInput, TKey>: This method asserts that the first item in the collection, after being sorted by a key, is equivalent to a given object.

In addition, these methods can raise a NullReferenceException if the collection is empty.
Here's an example of how to use ShouldlyExtension.Aggregates:

<pre>
public class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public void TestMethod()
{
    var myList = new List<MyClass>
    {
        new MyClass { Id = 1, Name = "Test 1"    },
        new MyClass { Id = 2, Name = "Test 2" },
        new MyClass { Id = 3, Name = "Test 3" }
    };

    // Assert that the last item in the list is equivalent to a given object
    myList.ShouldBeEquivalentToLastItem(new MyClass { Id = 3, Name = "Test 3" });

    // Assert that the last item in the list, after being sorted by a key, is equivalent to a given object
    myList.ShouldBeEquivalentToLastItem(x => x.Id, new MyClass { Id = 3, Name = "Test 3" });

    // Assert that the first item in the list is equivalent to a given object
    myList.ShouldBeEquivalentToFirstItem(new MyClass { Id = 1, Name = "Test 1" });

    // Assert that the first item in the list, after being sorted by a key, is equivalent to a given object
    myList.ShouldBeEquivalentToFirstItem(x => x.Id, new MyClass { Id = 1, Name = "Test 1" });
}
</pre>
