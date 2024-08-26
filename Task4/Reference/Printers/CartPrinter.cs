using Tasks.Task4.Reference.Models;
using Tasks.Task4.Reference.Handlers;

namespace Tasks.Task4.Reference.Printers;

public class CartPrinter
{
    private static string GetShoppingItemsPrint(CartModel shoppingCart)
    {
        return shoppingCart.Items
        .ToList()
        .Aggregate("", (itemsString, item) => $"{itemsString} \n {item.Name} x{item.Quantity}: ${CartHandler.GetItemPrice(item)}");
    }

    private static string GetPricingSummaryPrint(CartModel shoppingCart, CostSummaryModel costSummary)
    {
        var pricing = shoppingCart.Pricing;
        var totalPrice = costSummary.Total;

        return $"""
        Shipping: {pricing.ShippingCosts}
        Tax: {pricing.TaxPercentage}%
        Total Price: {totalPrice}
        """;
    }

    public static void PrintShoppingCart(CartModel shoppingCart, CostSummaryModel costSummary)
    {
        Console.WriteLine("Receipt:");
        Console.WriteLine(GetShoppingItemsPrint(shoppingCart));
        Console.WriteLine("\n");
        Console.WriteLine(GetPricingSummaryPrint(shoppingCart, costSummary));

    }
}
