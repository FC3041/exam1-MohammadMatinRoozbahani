namespace Exam1.Test;

[TestClass]
public class Q10StrategyTests
{
    [TestMethod]
    public void Q10_PricingStrategy_AllCases()
    {
        Assert.Inconclusive();
/*        var engine = new PricingEngine(new NoDiscountStrategy());

        // NoDiscountStrategy
        Assert.AreEqual(100.0, engine.CalculatePrice(100.0), 1e-9, "No discount should return the base price");

        // PercentageDiscountStrategy: 10% off
        engine.SetStrategy(new PercentageDiscountStrategy(0.10));
        Assert.AreEqual(90.0, engine.CalculatePrice(100.0), 1e-9, "10% off of 100 should be 90");

        // PercentageDiscountStrategy: 25% off
        engine.SetStrategy(new PercentageDiscountStrategy(0.25));
        Assert.AreEqual(75.0, engine.CalculatePrice(100.0), 1e-9, "25% off of 100 should be 75");

        // Switch back to NoDiscountStrategy
        engine.SetStrategy(new NoDiscountStrategy());
        Assert.AreEqual(200.0, engine.CalculatePrice(200.0), 1e-9, "Switching back to no discount returns base price");

        // Zero base price / no discount
        engine.SetStrategy(new NoDiscountStrategy());
        Assert.AreEqual(0.0, engine.CalculatePrice(0.0), 1e-9, "No discount on zero should be zero");

        // Zero base price / percentage discount
        engine.SetStrategy(new PercentageDiscountStrategy(0.50));
        Assert.AreEqual(0.0, engine.CalculatePrice(0.0), 1e-9, "Any percentage off zero should be zero");

        // 100% discount
        engine.SetStrategy(new PercentageDiscountStrategy(1.00));
        Assert.AreEqual(0.0, engine.CalculatePrice(150.0), 1e-9, "100% off should yield zero");

        // 50% off of a double price
        engine.SetStrategy(new PercentageDiscountStrategy(0.50));
        Assert.AreEqual(61.725, engine.CalculatePrice(123.45), 1e-9, "50% off of 123.45 should be 61.725");

        // 15% off with decimal result
        engine.SetStrategy(new PercentageDiscountStrategy(0.15));
        Assert.AreEqual(84.9915, engine.CalculatePrice(99.99), 1e-9, "15% off of 99.99 should be 84.9915");

        // Negative base price with a discount
        engine.SetStrategy(new PercentageDiscountStrategy(0.10));
        Assert.AreEqual(-90.0, engine.CalculatePrice(-100.0), 1e-9, "10% off of -100 should be -90");
*/
    }
}
