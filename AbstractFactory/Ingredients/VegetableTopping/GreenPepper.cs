using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.VegetableTopping
{
    public class GreenPepper : IVegetableTopping
    {
        public override string ToString() => "Sliced Green Bell Pepper";
    }
}
