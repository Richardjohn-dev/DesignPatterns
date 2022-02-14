using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizzas
{
    public class MeatFeastPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        private readonly PizzaType _pizzatype;

        public MeatFeastPizza(IPizzaIngredientFactory pizzaIngredientFactory, PizzaType pizzatype)
        : base(pizzatype) // pass into Pizza
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
            _pizzatype = pizzatype;
        }

        // Implement interface
        public override void Prepare()
        {
            Console.WriteLine($"Preparing { _pizzatype }");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheeses = _pizzaIngredientFactory.CreateCheeseToppings();
            MeatToppings = _pizzaIngredientFactory.CreateMeatToppings();           
        }
    }
}
