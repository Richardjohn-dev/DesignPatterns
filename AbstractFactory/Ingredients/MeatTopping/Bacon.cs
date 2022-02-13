using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.MeatTopping
{
    public class Bacon : IMeatTopping
    {
        public override string ToString() => "Bacon";
    }
}
