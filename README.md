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
##### note: It is compatible with Shouldly version 4.0.0 or higher.
make model for test with some properties:
<pre>
public class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}
</pre>
create unitTest : 
<pre>
public void TestMethod()
{
    var myList = new List<MyClass>
    {
        new MyClass { Id = 1, Name = "Test 1" },
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
more examples for assert : 
<pre>
    // Assert that the last item in the list is equivalent to a given object
    people.ShouldBeEquivalentToLastItem(new Person { Name = "Charlie", Age = 35 });
</pre>
with desc order : 
<pre>
 // Assert that the last item in the list, after being sorted by age, is equivalent to a given object
    people.ShouldBeEquivalentToLastItem(x => x.Age, new Person { Name = "Charlie", Age = 35 }, OrderType.Descending);
</pre>
with asce order : 
<pre>
  // Assert that the first item in the list, after being sorted by name, is equivalent to a given object
    people.ShouldBeEquivalentToFirstItem(x => x.Name, new Person { Name = "Alice", Age = 25 }, OrderType.Ascending);
</pre>

### Contributing
Contributions to ShouldlyExtension.Aggregate are welcome! If you find a bug or have an idea for a new feature, please open an issue and describe your problem or suggestion. If you would like to contribute code, please fork the repository and submit a pull request. All contributions should include tests to ensure that they work as expected.

### License
ShouldlyExtension.Aggregate is licensed under the MIT License.
