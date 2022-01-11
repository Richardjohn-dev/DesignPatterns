namespace StarBuzzDecorator
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
