using System;

namespace StarBuzzDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // without sizes
            Beverage beverage = new Espresso();
            beverage = new Marshmallows(beverage);
            Console.WriteLine($" { beverage.GetDescription() }  ${ beverage.Cost() }");

            // removed mocha. This is confusing to me, as a mocha is a beverage itself not a condiment (at least in England)

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Marshmallows(beverage2);
            beverage2 = new Marshmallows(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($" { beverage2.GetDescription() }  ${ beverage2.Cost() }");


            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Marshmallows(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($" { beverage3.GetDescription() }  ${ beverage3.Cost() }");

            Beverage beverage4 = new HouseBlend();
            beverage4 = new Soy(beverage4);
            beverage4 = new Whip(beverage4);
            Console.WriteLine($" { beverage4.GetDescription() }  ${ beverage4.Cost() }");

        }
    }
}
