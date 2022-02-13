using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Dough
{
    public class ThinCrustDough : IDough
    {
        public override string ToString() => "Thin Crust";
    }
}
