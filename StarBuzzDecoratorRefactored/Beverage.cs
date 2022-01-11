namespace StarBuzzDecoratorRefactored
{
    public abstract class Beverage
    {
        public BeverageSize Size { get; set; }
        public virtual string Description { get; protected set; } = "Unknown Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public void SetSize(BeverageSize size)
        {
            Size = size;
        }
        public BeverageSize GetSize()
        {
            return Size;
        }

        public abstract double Cost();
    }

    //public abstract class Beverage : Beverage
    //{
    //    public Beverage Beverage { get; set; }
    //    public abstract override string Description { get; }              
    //}
}
