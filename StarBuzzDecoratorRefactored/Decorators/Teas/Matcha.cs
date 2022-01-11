using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzDecoratorRefactored.Decorators.Teas
{
    public class Matcha : Beverage
    {
        public Matcha()
        {
            Description = "Matcha Green Tea";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
