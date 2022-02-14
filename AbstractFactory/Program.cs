using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore newYorkStore = new NewYorkPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            var pizza = newYorkStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Richard ordered a {pizza}\n");
            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Richard ordered a {pizza}\n");


            pizza = newYorkStore.OrderPizza(PizzaType.MeatFeast);
            Console.WriteLine($"Richard ordered a {pizza}\n");
            pizza = chicagoStore.OrderPizza(PizzaType.MeatFeast);
            Console.WriteLine($"Richard ordered a {pizza}\n");


            pizza = newYorkStore.OrderPizza(PizzaType.Veggie);
            Console.WriteLine($"Richard ordered a {pizza}\n");
            pizza = chicagoStore.OrderPizza(PizzaType.Veggie);
            Console.WriteLine($"Richard ordered a {pizza}\n");

            Console.WriteLine("And a diet coke.");
        }          
    }
}
