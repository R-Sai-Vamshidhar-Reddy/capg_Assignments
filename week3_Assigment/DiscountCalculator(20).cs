namespace Assessmentc_
{
    // Discount strategy interface
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal total);
    }

    // No discount strategy
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total;
        }
    }

    // Percentage discount strategy
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - (total * _percentage / 100);
        }
    }

    // Fixed amount discount strategy
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _amount;

        public FixedAmountDiscount(decimal amount)
        {
            _amount = amount;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - _amount;
        }
    }

    // Shopping cart class
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal total)
        {
            return _discountStrategy.ApplyDiscount(total);
        }
    }

    
    
}
