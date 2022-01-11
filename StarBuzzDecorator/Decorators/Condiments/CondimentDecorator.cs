namespace StarBuzzDecorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }
        public abstract override string Description { get; }
    }
}
