using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzDecoratorRefactored.Decorators.Teas
{
    public class YorkshireTea : Beverage
    {
        public YorkshireTea()
        {
            Description = "Yorkshire Tea";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
