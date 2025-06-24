using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DecoratorPattern
{
    internal class Bubble : CondimentDecorator
    {
        Beverage beverage;
        public Bubble(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + 5;
        }

        public override string GetDescription()
        {
            string name = beverage.GetDescription() + ", Bubble";
            return name;
        }
       
    }
}
