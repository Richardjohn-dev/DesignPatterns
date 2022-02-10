using System;

namespace TheFactoryPatternStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = new SimplePizzaFactory();
            var pizza = factory.CreatePizza("cheese");
            Console.WriteLine($"Thats a nice {nameof(pizza)}");

        }     
    }
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("peperoni"))
            {
                pizza = new Peperoni();
            }
            else if (type.Equals("Meatfeast"))
            {
                pizza = new Meatfeast();
            }
            else
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }

    // Factory is passed into the Pizza Store
    public class PizzaStore
{
    private readonly SimplePizzaFactory _factory;
    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    }

    public Pizza OrderPizza(string type)
    {
        // now we don't have any instantiation
        var pizza = _factory.CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}


    public abstract class Pizza
    {
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }

    public class CheesePizza : Pizza
    {
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Box()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
    public class GreekPizza : Pizza
    {
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Box()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }

    public class Meatfeast : Pizza
    {
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Box()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }

    public class Peperoni : Pizza
    {
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Box()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}




    // This is code that is not closed for midification



