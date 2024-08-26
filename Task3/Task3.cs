namespace Tasks.Task3;

// Task 3 | Discriminated unions and pattern matching
// --------------------
// Use discriminated unions (classes with common interface)
// and use pattern matching (switch) to write a message for each object type
// and Console.WriteLine them out to console.
// --------------------
// Advantages:
// 1. Specific data structures that can be pattern matched to separate them.
// 2. Not a single class with a lot of props that are null and vary between objects.
// 3. Easier to model whole business logic quite specific and explicit.

interface ICommonObject { public int Id { get; } };
record Object1(int Id, string Name) : ICommonObject;
record Object2(int Id, string Title) : ICommonObject;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        var list = new List<ICommonObject> {
            new Object1(1, "object1"),
            new Object1(3, "object3"),
            new Object2(2, "object2"),
            new Object2(4, "object4"),
        };

        // Complete code here ..

    }
}
