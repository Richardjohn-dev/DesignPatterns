using System;

namespace AbstractFactory.Pizzas
{
    public class VegetarianPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        private readonly PizzaType _pizzatype;

        public VegetarianPizza(IPizzaIngredientFactory pizzaIngredientFactory, PizzaType pizzatype)
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
            VegetableToppings = _pizzaIngredientFactory.CreateVegetableToppings();
            // Future changes we could Inject pizzaType to get vegetarian Cheese (Strategy Pattern)
        }
    }
}
