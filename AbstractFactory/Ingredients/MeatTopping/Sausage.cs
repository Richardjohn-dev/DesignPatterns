using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.MeatTopping
{
    public class Sausage : IMeatTopping
    {
        public override string ToString() => "Sausage";
    }
}
