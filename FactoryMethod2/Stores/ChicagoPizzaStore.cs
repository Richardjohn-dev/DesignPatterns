namespace FactoryMethod2
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzatype) => pizzatype switch // have to implement abstract Method.
        {
            PizzaType.Cheese => new ChicagoCheesePizza(),
            PizzaType.Veggie => new ChicagoStyleVeggiePizza(),
            PizzaType.Peperoni => new ChicagoStylePepperoniPizza(),
            _ => new ChicagoCheesePizza(), // default to cheese
        };
    }
}
