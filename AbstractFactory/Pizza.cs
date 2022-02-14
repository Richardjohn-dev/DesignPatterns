using AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected Pizza(PizzaType pizzatype)
        {
            Name = pizzatype;
        }
        public PizzaType Name { get; init; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public List<IVegetableTopping> VegetableToppings { get; protected set; }
        public List<IMeatTopping> MeatToppings { get; protected set; }
        public List<ICheese> Cheeses { get; protected set; }

        public abstract void Prepare();
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

        //public string GetName()
        //{
        //    return Name;
        //}
        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("---- ").Append(Name).Append(" ----\n");
            if (Dough != null)
            {
                result.Append(Dough).Append('\n');
            }

            if (Sauce != null)
            {
                result.Append(Sauce).Append('\n');
            }

            if (Cheeses != null)
            {
                result.AppendJoin(", ", Cheeses);
                result.Append('\n');
            }

            if (VegetableToppings != null)
            {
                result.AppendJoin(", ", VegetableToppings);
                result.Append('\n');
            }

            if (MeatToppings != null)
            {
                result.AppendJoin(", ", MeatToppings);
                result.Append('\n');
            }

            return result.ToString();
        }
    }
}
