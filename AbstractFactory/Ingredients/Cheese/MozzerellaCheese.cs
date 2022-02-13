using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Cheese
{
    public class MozzerellaCheese : ICheese
    {
        public override string ToString() => "Shredded Mozzarella";
    }
}
