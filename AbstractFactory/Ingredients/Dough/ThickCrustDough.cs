using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Dough
{
    public class ThickCrustDough : IDough
    {
        public override string ToString() => "Thick Crust";
    }
}
