namespace StarBuzzDecoratorRefactored
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            double c = .99; // default small
            BeverageSize size = base.GetSize();

            if (size == BeverageSize.Medium)
                c = 1.49;

            if (size == BeverageSize.Large)
                c = 1.99;

            return c;
        }
    }
}
