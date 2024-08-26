namespace Tasks.Task1;

// Task 1 | Mutations
// --------------------
// Rewrite code to be immutable
// --------------------
// Advantages:
// 1. Immutable code is easier to read
// 2. Easier to reason about
// 3. Easier to test - no side effects
// 4. Easier to maintain

public class UnitTest
{
    public class MyObject
    {
        public int Number { get; set; }
    }

    [Fact]
    public void Test()
    {
        var obj1 = new MyObject { Number = 1 };
        var obj2 = new MyObject { Number = 2 };
        var obj3 = new MyObject { Number = 3 };
        var list = new List<MyObject> { obj1, obj2, obj3 };

        foreach (var numberObject in list)
        {
            numberObject.Number += 2;
        }

        foreach (var numberObject in list)
        {
            Console.WriteLine(numberObject.Number);
        }
    }
}
