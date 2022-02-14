using System;

namespace TheFactoryPatternStart
{
    class Program
    {
        // stripped out the pizza store.. it was extra fluff that potentionally added confusion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = new SimplePizzaFactory();
            var pizza = factory.CreatePizza("cheese");

        }
    }
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            // Our Factory is Dependant on all these objects. (not great)
            // If we want to make changes..this class is not closed for modification.
            Pizza pizza;
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
                Console.WriteLine("Cheese pizza created!");
            }
            else if (type.Equals("peperoni"))
            {
                pizza = new Peperoni();
                Console.WriteLine("peperoni pizza created!");

            }
            else if (type.Equals("Meatfeast"))
            {
                pizza = new Meatfeast();
                Console.WriteLine("Meat feast pizza created!");
            }
            else
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }
    public abstract class Pizza
    {    
    }

    public class CheesePizza : Pizza
    {
  
    }
    public class GreekPizza : Pizza
    {       
    }
    public class Meatfeast : Pizza
    {      
    }
    public class Peperoni : Pizza
    {      
    }
}

