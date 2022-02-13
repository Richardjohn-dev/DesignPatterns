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

        public ICheese CreateCheese();

        public List<IVegetableTopping> CreateVegetableToppings();

        public List<IMeatTopping> CreateMeatToppings();

    }
}
