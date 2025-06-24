using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DecoratorPattern
{
    internal class CreamFoam : CondimentDecorator
    {
        Beverage beverage;
        public CreamFoam(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + 10;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", CreamFoam";
        }

    }
}
