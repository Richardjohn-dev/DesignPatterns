namespace StarBuzzDecorator
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description => $"{Beverage.Description}, {nameof(SteamedMilk)}";

        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }
    }
}
