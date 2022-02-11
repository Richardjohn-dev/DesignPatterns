using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2.Pizzas.Napoli
{
    public class NeopolitanPizza : Pizza
    {
        public NeopolitanPizza()
        {
            Name = "Classic Neapolitan pizzas";
            Dough = "Thin Crust Dough";
            Sauce = "Neapolitan San Marzano Sauce";
            Toppings.Add("Mozzerella di Bufala Campana");
            Toppings.Add("Fresh Basil");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking for 60 seconds at 500 degrees");
        }
    }

    //The pizza must be baked for 60–90 seconds in a 485 °C(905 °F) wood-fired oven.[5] When cooked, it should be soft, elastic, tender and fragrant.
}
