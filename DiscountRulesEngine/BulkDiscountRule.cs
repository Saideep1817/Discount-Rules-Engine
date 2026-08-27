namespace DiscountRulesEngine
{
    public sealed class BulkDiscountRule : IDiscountRule
    {
        public decimal Apply(decimal subtotal)
        {
            if (subtotal >= 2000m)
            {
                return subtotal - 200m; // Apply a 200 discount
            }
            return subtotal;
        }
    }
}