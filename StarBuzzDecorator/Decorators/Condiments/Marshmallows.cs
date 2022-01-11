namespace StarBuzzDecorator{
    public class Marshmallows : CondimentDecorator
    {

        public Marshmallows(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override string Description => $"{Beverage.Description}, {nameof(Marshmallows)}";

        public override double Cost()
        {
            return .30 + Beverage.Cost();
        }
    }
}
