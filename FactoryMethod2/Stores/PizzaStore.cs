﻿namespace FactoryMethod2
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        protected abstract Pizza CreatePizza(PizzaType pizzatype);

    }
}
