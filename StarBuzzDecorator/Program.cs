using System;

namespace StarBuzzDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Beverage
    {
        public string Description { get; set; } = "Unknown Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }



    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }
        public abstract string GetDescription();
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }



    public class Mocha : CondimentDecorator
    {

        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }
    }

    public class SteamedMilk : CondimentDecorator
    {

        public SteamedMilk(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }
    }

    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return .15 + Beverage.Cost();
        }

    }

    public class Whip : CondimentDecorator
    {

        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }
    }
}
