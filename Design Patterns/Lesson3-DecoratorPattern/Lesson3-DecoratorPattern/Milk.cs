using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DecoratorPattern
{
    internal class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage) 
        {
            this.beverage = beverage;
        }
        
        public override double cost()
        {
            double cost = beverage.cost();
            Size beverageSize = beverage.GetSize();
            switch (beverageSize)
            {
                case Size.Tall:
                    cost += 30;
                    break;
                case Size.Middle:
                    cost += 20;
                    break;
                case Size.Small:
                    cost += 10;
                    break;
            }
            return cost;
        }

        public override string GetDescription()
        {
            string name= beverage.GetDescription() + ", Milk";
            return name;
        }
    }
}
