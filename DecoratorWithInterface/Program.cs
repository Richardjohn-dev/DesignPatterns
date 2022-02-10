using System;

namespace DecoratorWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
ISandwichIngredient wholemeal = new WholemealSandwich();
ISandwichIngredient withCheese = new Cheese(wholemeal);
ISandwichIngredient withMustard = new Mustard(withCheese);

Console.WriteLine($" { withMustard.Description() }. Cost: { withMustard.Cost() } ");


            //ISandwichIngredient concrete2 = new WholemealSandwich();
            //ISandwichIngredient withCheese2 = new Cheese(concrete2);
            //ISandwichIngredient withCucumber2 = new Cucumber(withCheese2);
            //ISandwichIngredient withMustard2 = new Mustard(withCucumber2);

            //Console.WriteLine($" { withMustard2.Description() }. Cost: { withMustard2.Cost() } ");
        }


        public interface ISandwichIngredient
        {
            double Cost();
            string Description();
        }

        public class WholemealSandwich : ISandwichIngredient
        {
            public WholemealSandwich()
            {
                Console.WriteLine("Bread layer");
            }
            public double Cost()
            {
                return 1.99;
            }

            public string Description()
            {
                Console.WriteLine("bread layer");
                return "Wholemeal Sandwich";
            }
        }

        public class Cheese : ISandwichIngredient
        {
            private readonly ISandwichIngredient _inner;

            public Cheese(ISandwichIngredient inner)
            {
                _inner = inner;
                Console.WriteLine("cheese layer");
            }
            public double Cost()
            {
                return .50 + _inner.Cost();
            }

            public string Description()
            {
                Console.WriteLine("cheese layer");

                return $"{_inner.Description()}, {nameof(Cheese)}";
            }


        }

        public class Cucumber : ISandwichIngredient
        {
            private readonly ISandwichIngredient _inner;

            public Cucumber(ISandwichIngredient inner)
            {
                _inner = inner;
            }
            public double Cost() =>  .20 + _inner.Cost();
            
            public string Description() => $"{_inner.Description()}, {nameof(Cucumber)}";
        }

        public class Ham : ISandwichIngredient
        {
            public double Cost()
            {
                throw new NotImplementedException();
            }

            public string Description()
            {
                throw new NotImplementedException();
            }
        }

public class Mustard : ISandwichIngredient
{
    private readonly ISandwichIngredient _inner;

    public Mustard(ISandwichIngredient inner)
    {
        _inner = inner;
    }
    public double Cost() => .40 + _inner.Cost();
    public string Description() => $"{_inner.Description()}, {nameof(Mustard)}";
}
    }
}
