namespace StarBuzzDecoratorRefactored
{
    public abstract class BeverageWithCondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }
        public abstract override string Description { get; }
    }
}
