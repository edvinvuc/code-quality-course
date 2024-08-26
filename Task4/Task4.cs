namespace Tasks.Task4;

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

class ShoppingCart
{
    public List<Item> Items { get; set; }
    public double ShippingCost { get; set; }
    public double TaxPercentage { get; set; }

    public ShoppingCart()
    {
        Items = new List<Item>();
        ShippingCost = 5.0; // Default shipping cost
        TaxPercentage = 0;
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var item in Items)
        {
            totalPrice += item.Price * item.Quantity;
        }

        // Apply taxes
        totalPrice += (totalPrice * TaxPercentage / 100);

        // Add shipping cost
        totalPrice += ShippingCost;

        // Round total price to 2 decimal places
        totalPrice = Math.Round(totalPrice, 2);

        return totalPrice;
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Receipt:");
        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Name} x{item.Quantity}: ${item.Price * item.Quantity}");
        }

        Console.WriteLine($"Shipping: ${ShippingCost}");
        Console.WriteLine($"Tax: {TaxPercentage}%");
        Console.WriteLine($"Total Price: ${CalculateTotalPrice()}");
    }
}

class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}


public class UnitTest
{
    [Fact]
    public void Test()
    {
        var cart = new ShoppingCart();
        cart.Items.Add(new Item { Name = "Laptop", Price = 1000, Quantity = 1 });
        cart.Items.Add(new Item { Name = "Mouse", Price = 50, Quantity = 2 });
        cart.Items.Add(new Item { Name = "Keyboard", Price = 100, Quantity = 1 });

        cart.TaxPercentage = 8;

        cart.PrintReceipt();
    }
}
