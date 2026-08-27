namespace DiscountRulesEngine
{
    public sealed class PremiumDiscountRule : IDiscountRule
    {
        public decimal Apply(decimal subtotal)
        {
            if (subtotal >= 2000m)
            {
                return subtotal * 0.85m; // Apply a 15% discount

            }
            return subtotal;
        }
    }
}