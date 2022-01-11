using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzDecoratorRefactored.Decorators.Teas
{
    public class Chai : Beverage
    {
        public Chai()
        {
            Description = "Chai Tea";
        }
        public override double Cost()
        {
            return 1.59;
        }
    }
}
