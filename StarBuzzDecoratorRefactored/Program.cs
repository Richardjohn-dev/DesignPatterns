using StarBuzzDecoratorRefactored.Decorators.Teas;
using System;

namespace StarBuzzDecoratorRefactored
{
    // refactoring with beverage sizes as additional update
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage.SetSize(BeverageSize.Small);
            beverage = new Marshmallows(beverage);
            Console.WriteLine($" { beverage.GetSize() } { beverage.GetDescription() }  ${ beverage.Cost() }");

            Beverage beverage2 = new YorkshireTea();
            beverage2.SetSize(BeverageSize.Large);
            beverage2 = new Marshmallows(beverage2);
            Console.WriteLine($" { beverage2.GetSize() } { beverage2.GetDescription() }  ${ beverage2.Cost() }");

            //Beverage beverage2 = new DarkRoast();
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Whip(beverage2);
            //Console.WriteLine($" { beverage2.GetDescription() }  ${ beverage2.Cost() }");


            //Beverage beverage3 = new HouseBlend();
            //beverage3 = new Soy(beverage3);
            //beverage3 = new Mocha(beverage3);
            //beverage3 = new Whip(beverage3);
            //Console.WriteLine($" { beverage3.GetSize() } { beverage3.GetDescription() }  ${ beverage3.Cost() }");

            //Beverage beverage4 = new HouseBlend();
            //beverage4 = new Soy(beverage4);
            //beverage4 = new Mocha(beverage4);
            //beverage4 = new Whip(beverage4);
            //Console.WriteLine($" { beverage4.GetSize() } { beverage4.GetDescription() }  ${ beverage4.Cost() }");

        }
    }
}
