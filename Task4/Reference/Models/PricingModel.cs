namespace Tasks.Task4.Reference.Models;

public record PricingModel(
    double TaxPercentage,
    double ShippingCosts = 5.0
);
