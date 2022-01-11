namespace StarBuzzDecorator
{
    public class Whip : CondimentDecorator
    {

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override string Description => $"{Beverage.Description}, {nameof(Whip)}";

        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }
    }
}
