
    
    public interface IPricingStrategy
    {
        double CalculateFinalPrice(double basePrice);}

   
    public class NoDiscountStrategy : IPricingStrategy
    {
        public double CalculateFinalPrice(double basePrice)
        {
            return basePrice;}}

    
    public class PercentageDiscountStrategy : IPricingStrategy
    {
        private readonly double _discountRate;

        public PercentageDiscountStrategy(double discountRate)
        {
            if (discountRate < 0 || discountRate > 1)
                throw new ArgumentOutOfRangeException("Discount rate must be between 0 and 1");
            
            _discountRate = discountRate;}

        public double CalculateFinalPrice(double basePrice)
        {
            return basePrice * (1 - _discountRate);}}

    
    public class PricingEngine
    {
        private IPricingStrategy _strategy;

        public PricingEngine(IPricingStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));}

        public void SetStrategy(IPricingStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));}

        public double CalculatePrice(double basePrice)
        {
            return _strategy.CalculateFinalPrice(basePrice);}}

