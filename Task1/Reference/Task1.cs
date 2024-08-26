namespace Tasks.Task1.Reference;

// Task 1 | Mutations
// --------------------
// Rewrite code to be immutable
// --------------------
// Advantages:
// 1. Immutable code is easier to read
// 2. Easier to reason about
// 3. Easier to test - no side effects
// 4. Easier to maintain

// public class UnitTest1Reference
// {
//     public class MyObject
//     {
//         public int Number { get; set; }
//     }

//     [Fact]
//     public void Test1()
//     {
//         var obj1 = new MyObject { Number = 1 };
//         var obj2 = new MyObject { Number = 2 };
//         var obj3 = new MyObject { Number = 3 };
//         var list = new List<MyObject> { obj1, obj2, obj3 };

//         foreach (var numberObject in list)
//         {
//             numberObject.Number += 2;
//         }

//         foreach (var numberObject in list)
//         {
//             Console.WriteLine(numberObject.Number);
//         }
//     }
// }

public class UnitTest
{
    record MyObject(int Number);

    [Fact]
    public void Test()
    {
        var list = new List<MyObject> {
            new MyObject(1),
            new MyObject(2),
            new MyObject(3)
        };

        var incrementedList = list.Select(obj => obj with { Number = obj.Number + 2 }).ToList();

        incrementedList.ForEach(Console.WriteLine);
    }
}
