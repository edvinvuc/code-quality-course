using Tasks.Task4.Reference.Models;

namespace Tasks.Task4.Reference.Handlers;

public class CartHandler
{
    public static CartModel AddItems(CartModel shoppingCart, List<ItemModel> items)
         => shoppingCart with { Items = shoppingCart.Items.Concat(items).ToList() };

    public static CartModel ChangeTaxPercentage(CartModel shoppingCart, double taxPercentage)
        => shoppingCart with { Pricing = shoppingCart.Pricing with { TaxPercentage = taxPercentage } };

    public static CartModel ChangeShippingCosts(CartModel shoppingCart, double shippingCosts)
        => shoppingCart with { Pricing = shoppingCart.Pricing with { ShippingCosts = shippingCosts } };

    public static double GetItemPrice(ItemModel item) => item.Price * item.Quantity;

    private static double GetSumExTax(List<ItemModel> items) => items.Sum(GetItemPrice);

    private static double GetSumTax(double sumExTax, double taxPercentage) => sumExTax * taxPercentage / 100;

    public static double CalculateTotalPrice(CartModel shoppingCart)
    {
        var sumExTax = GetSumExTax(shoppingCart.Items);
        var sumTax = GetSumTax(sumExTax, shoppingCart.Pricing.TaxPercentage);
        var shipping = shoppingCart.Pricing.ShippingCosts;

        return sumExTax + sumTax + shipping;
    }

    public static CostSummaryModel CalculateCostSummary(CartModel shoppingCart)
    {
        var total = CalculateTotalPrice(shoppingCart);

        return new CostSummaryModel(total);
    }
}
