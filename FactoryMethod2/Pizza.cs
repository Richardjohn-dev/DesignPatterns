using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    public abstract class Pizza
    {

        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new();

        public void Prepare()
        {
            Console.WriteLine($"Prepare {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($"\t{topping}");
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            var displayName = new StringBuilder();
            displayName.Append("---- ").Append(Name).Append(" ----\n");
            displayName.Append(Dough).Append('\n');
            displayName.Append(Sauce).Append('\n');
            foreach (string topping in Toppings)
            {
                displayName.Append(topping).Append('\n');
            }

            return displayName.ToString();
        }
    }
}
