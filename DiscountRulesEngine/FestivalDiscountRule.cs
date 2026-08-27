namespace DiscountRulesEngine
{
    public sealed class FestivalDiscountRule : IDiscountRule
    {
        public decimal Apply(decimal subtotal)
        {
            if (subtotal >= 500m)
            {
                return subtotal * 0.9m; // Apply a 10% discount
            }
            return subtotal;
        }
    }
}