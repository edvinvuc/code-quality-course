namespace Tasks.Task2;

// Task 2 | Linq
// --------------------
// Merge two object lists together by id into ObjectType3 by using linq (immutable).
// Use functional linq and not sql like linq to get a feel of the structure of
// creating reusable functions.
// Print out only the matching objects.
// --------------------
// Advantages:
// 1. Reusable functions - Less code - less that go wrong
// 2. Is immutable - easy to reason about, more linear written.
// 3. Linq give easily type signature in > out -> easy to follow
//
// Some learning curve to fully use its potential. But worth it.
// Linq also has a sql like language alternative as well for those
// who like that better.

record ObjectType1(int Id, string Name);
record ObjectType2(int Id, string Title);
record ObjectType3(int Id, string Name, string Title);

public class UnitTest
{
    [Fact]
    public void Test()
    {
        var list1 = new List<ObjectType1> {
            new ObjectType1(1, "object #1"),
            new ObjectType1(2, "object #2"),
            new ObjectType1(99, "object #99"),
            new ObjectType1(3, "object #3"),
        };

        var list2 = new List<ObjectType2> {
            new ObjectType2(1, "This is object #1"),
            new ObjectType2(2, "This is object #2"),
            new ObjectType2(3, "This is object #3"),
        };

        // Complete code here ..
    }
}
