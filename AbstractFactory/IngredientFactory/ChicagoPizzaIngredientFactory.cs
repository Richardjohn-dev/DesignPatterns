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
public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough() => new ThickCrustDough();
    public ISauce CreateSauce() => new PlumTomatoSauce();
    public List<ICheese> CreateCheeseToppings()
    {
        return new List<ICheese>()
        {
            new MozzerellaCheese(),
            new ParmesanCheese()
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
    public List<IMeatTopping> CreateMeatToppings()
    {
        return new List<IMeatTopping>()
        {
            new Pepperoni(),
            new Ham(),
            new Sausage()
        };
    }
    public List<IVegetableTopping> CreateVegetableToppings()
    {
        return new List<IVegetableTopping>()
        {
            new BlackOlives(),
            new Mushroom(),
            new Onion(),
            new Tomato()
        };
    }
}
}
