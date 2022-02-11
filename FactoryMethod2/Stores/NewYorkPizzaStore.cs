namespace FactoryMethod2
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzatype) => pizzatype switch // have to implement abstract Method.
        {
            PizzaType.Cheese => new NewYorkCheese(),
            PizzaType.Veggie => new NewYorkVeggie(),
            PizzaType.Peperoni => new NewYorkPeperoni(),
            _ => new ChicagoCheesePizza(), // default to cheese
        };
    }
}
