using System;

namespace TheFactoryPatternStart
{
    class Program
    {
        // stripped out the pizza store wrapper/DI.. it was extra fluff that potentionally added confusion
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
            Pizza pizza;
            if (type.Equals("cheese"))
            {
                // Our Factory is Dependant on all these objects. (not great)
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
            // If we want to make changes..this class is not closed for modification.

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

