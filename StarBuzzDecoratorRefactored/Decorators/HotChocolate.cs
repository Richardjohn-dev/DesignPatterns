using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzDecoratorRefactored.Decorators
{
    public class HotChocolate : Beverage
    {
        public HotChocolate()
        {
            Description = "Hot Chocolate";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
