using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Herbs;
using AbstractFactory.Ingredients.MeatTopping;
using AbstractFactory.Ingredients.Sauce;
using AbstractFactory.Ingredients.VegetableTopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.IngredientFactory
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public List<ICheese> CreateCheeseToppings()
        {
            return new List<ICheese>()
            {
                new BuffaloMozzerellaCheese(),
                new ParmigianoReggianoCheese()
            };
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public List<IMeatTopping> CreateMeatToppings()
        {
            return new List<IMeatTopping>()
            {
                new Pepperoni(),
                new Ham(),
                new Sausage(),
                new Chicken(),
                new MinceBeef(),
                new Bacon()
            };
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVegetableTopping> CreateVegetableToppings()
        {
            return new List<IVegetableTopping>()
            {
                new BlackOlives(),
                new Mushroom(),
                new Onion(),
                new Tomato(),
                new RedPepper(),
                new GreenPepper(),
                new Jalapeno(),
                new Brocolli(),
                new SweetCorn()
            };
        }

        public List<IHerb> CreateHerbToppings()
        {
            return new List<IHerb>()
            {
                new Basil(),
                new Oregano()
            };
        }
    }
}
