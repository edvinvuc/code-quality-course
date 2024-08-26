using Tasks.Task4.Reference.Models;
using Tasks.Task4.Reference.Handlers;
using Tasks.Task4.Reference.Printers;

namespace Tasks.Task4.Reference;

// Task 4 | Refactoring
// --------------------
// In this section think about:
// 1. Separate pure functions as much as possible from unpure functions
// 2. Separate data and functions
// 3. All data structures and functions needs to be immutable
// 4. All functions should have both input and output values
// 5. All pure functions should have no side effects (outside mutations, file read/write, api call in/out)
// 6. All unpure in functions needs to be validated for data structure
// 7. Use linq for handling data logic
// 8. Use discriminated unions if needsed to be specific about data and reduce nulls.
// 9. Make all functions as small as possible (think single responsibility. And build them ontop of each other.
// Easier to reson about, reuse, test and error handle.
//
// Clean code:
// 1. Early return with ifs instead of nested if else.
// 2. Good variable names that explains the intention. Better than a lot of comments - or none.
// 3. Reuse code
//
// SOLID:
// 1. Single responsibility pattern

public class UnitTest
{
    [Fact]
    public void Test()
    {
        var item1 = new ItemModel("Laptop", 1000, 1);
        var item2 = new ItemModel("Mouse", 50, 2);
        var item3 = new ItemModel("Keyboard", 100, 1);
        var cartItems = new List<ItemModel> { item1, item2, item3 };
        var cartPricing = new PricingModel(25);

        var cart = new CartModel(cartItems, cartPricing);
        var costSummary = CartHandler.CalculateCostSummary(cart);

        CartPrinter.PrintShoppingCart(cart, costSummary);
    }
}
