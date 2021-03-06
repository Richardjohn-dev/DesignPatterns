using AbstractFactory.IngredientFactory;
using AbstractFactory.Pizzas;

namespace AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzatype)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            return pizzatype switch
            {
                PizzaType.Cheese => new CheesePizza(ingredientFactory, PizzaType.Cheese),
                PizzaType.Veggie => new VegetarianPizza(ingredientFactory, PizzaType.Veggie),
                PizzaType.MeatFeast => new MeatFeastPizza(ingredientFactory, PizzaType.MeatFeast),
                _ => new CheesePizza(ingredientFactory, PizzaType.Cheese), // default to cheese could be null
            };
        }
    }
}
