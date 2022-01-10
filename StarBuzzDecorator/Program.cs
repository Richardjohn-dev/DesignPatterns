using System;

namespace StarBuzzDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($" { beverage.GetDescription() }  ${ beverage.Cost() }");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($" { beverage2.GetDescription() }  ${ beverage2.Cost() }");


            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($" { beverage3.GetDescription() }  ${ beverage3.Cost() }");

        }
    }

    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }



    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }
        //public abstract string GetDescription();
        //public abstract override string GetDescription { get; }
        public abstract override string Description { get; }
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
            Beverage = beverage;
        }
        //public override string Description
        //{
        //    return Beverage.GetDescription() + ", Mocha";
        //}

        public override string Description => $"{Beverage.Description}, {nameof(Mocha)}";

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }
    }

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

    public class Soy : CondimentDecorator
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
