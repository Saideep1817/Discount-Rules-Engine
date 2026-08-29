using DiscountRulesEngine;

namespace DiscountRulesEngine.Tests;

public class UnitTest1
{
    [Fact]
    public void PremiumDiscount_ShouldApply15Percent_WhenSubtotalIs2000OrMore()
    {
        var rule = new PremiumDiscountRule();

        var result = rule.Apply(2000m);

        Assert.Equal(1700m, result);
    }

    [Fact]
    public void PremiumDiscount_ShouldNotApply_WhenSubtotalIsLessThan2000()
    {
        var rule = new PremiumDiscountRule();

        var result = rule.Apply(1000m);

        Assert.Equal(1000m, result);
    }

    [Fact]
    public void BulkDiscount_ShouldSubtract200_WhenSubtotalIs1500OrMore()
    {
        var rule = new BulkDiscountRule();

        var result = rule.Apply(2000m);

        Assert.Equal(1800m, result);
    }

    [Fact]

    public void BulkDiscount_ShouldNotSubtract200_WhenSubtotalIsLessThan1500()
    {
        var rule = new BulkDiscountRule();

        var result = rule.Apply(1200m);

        Assert.Equal(1200m, result);
    }
    [Fact]
    public void FestivalDiscount_ShouldApply10Percent_WhenSubtotalIs500OrMore()
    {
        var rule = new FestivalDiscountRule();

        var result = rule.Apply(500m);

        Assert.Equal(450m, result);
    }

    [Fact]
    public void FestivalDiscount_ShouldNotApply_WhenSubtotalIsLessThan500()
    {
        var rule = new FestivalDiscountRule();

        var result = rule.Apply(400m);

        Assert.Equal(400m, result);
    }
}