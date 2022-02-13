using System;
using System.Collections.Generic;

namespace FactoryMethod2
{
    class Program
    {
        // note that this is parameterized factory method.
        static void Main(string[] args)
        {
            //That's the idea of this method. The ConcreteCreators tell the AbstractCreator which ConcreteProduct to use!!!
            var NewYorkPizzaStore = new NewYorkPizzaStore();
            var pizza = NewYorkPizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Richard ordered a {pizza.Name}\n");

            var NapoliPizzaStore = new NaplesPizzaStore();
            pizza = NapoliPizzaStore.OrderPizza(PizzaType.Veggie);
            // what if this store only did 1 type of pizza? // nullable enum?
            Console.WriteLine($"Richard ordered a {pizza.Name}\n");

            // What if we opened a chain of vegetarian pizza restaurants?
            // how would we deal with not accepting meat orders?
            // E.g restrict pizza types to certain factories

          
        }
    }
}
