namespace Tasks.Task2.Reference;

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

        var list3 = list1.Join(
            list2,
            o1 => o1.Id,
            o2 => o2.Id,
            (o1, o2) => new ObjectType3(o1.Id, o1.Name, o2.Title)
        );

        list3.ToList().ForEach(Console.WriteLine);
    }
}
