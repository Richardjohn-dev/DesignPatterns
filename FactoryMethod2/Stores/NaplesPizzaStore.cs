using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod2.Pizzas.Napoli;

namespace FactoryMethod2
{
    public class NaplesPizzaStore : PizzaStore
    {
        // what if we had a factory that only produce one product, and we have to limit the types?

        protected override Pizza CreatePizza(PizzaType pizzatype) => pizzatype switch // have to implement abstract Method.
        {
             _ => new NeopolitanPizza() // default to cheese
        };
    }
}
