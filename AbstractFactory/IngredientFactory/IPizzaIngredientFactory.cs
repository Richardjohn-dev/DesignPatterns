using AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public List<ICheese> CreateCheeseToppings();
    public List<IVegetableTopping> CreateVegetableToppings();
    public List<IMeatTopping> CreateMeatToppings();
    public List<IHerb> CreateHerbToppings();
    // Look familiar?? These are Factory Methods Within our Abstract Factory.
}
}
