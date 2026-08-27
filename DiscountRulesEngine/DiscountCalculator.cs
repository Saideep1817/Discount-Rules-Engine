using System;
using System.Collections.Generic;

namespace DiscountRulesEngine
{
    public sealed class DiscountCalculator
    {
        private readonly IEnumerable<IDiscountRule> rules;
        public DiscountCalculator(IEnumerable <IDiscountRule> rules)
        {
            this.rules = rules;
        }

        public decimal Calculate(decimal subtotal)
        {
            if (subtotal < 0m)
            {
                throw new ArgumentOutOfRangeException(nameof(subtotal));
            }
            decimal amount = subtotal;
            foreach (IDiscountRule rule in rules)
            {
                amount = rule.Apply(amount);
            }
            return amount;
        }
    }
}