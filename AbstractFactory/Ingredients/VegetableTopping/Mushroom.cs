using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.VegetableTopping
{
    public class Mushroom : IVegetableTopping
    {
        public override string ToString() => "Mushroom";
    }
}
