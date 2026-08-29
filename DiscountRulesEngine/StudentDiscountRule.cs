namespace DiscountRulesEngine
{
    public sealed class StudentDiscountRule : IDiscountRule
    {
        public decimal Apply(decimal subtotal)
        {
            return subtotal * 0.9m;
        }
    }
}