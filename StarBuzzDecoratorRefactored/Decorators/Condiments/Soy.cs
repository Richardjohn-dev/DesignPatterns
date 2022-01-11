namespace StarBuzzDecoratorRefactored
{
    public class Soy : BeverageWithCondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description => $"{Beverage.Description}, {nameof(Soy)}";

        public override double Cost()
        {
            return .15 + Beverage.Cost();
        }

    }
}
