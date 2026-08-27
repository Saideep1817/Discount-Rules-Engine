namespace DiscountRulesEngine
{
    public interface IDiscountRule
    {
        decimal Apply(decimal totalAmount);
    }
}
