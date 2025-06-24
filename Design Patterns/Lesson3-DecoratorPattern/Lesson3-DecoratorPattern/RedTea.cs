using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DecoratorPattern
{
    internal class RedTea : Beverage
    {
       
        public RedTea() 
        {
            base.description = "Red Tea";
        }
        public override double cost()
        {
            double cost = 20;
            switch (GetSize())
            {
                case Size.Tall:
                    cost += 10;
                    break;
                case Size.Middle:
                    cost += 5;
                    break;
                case Size.Small:
                    cost += 0;
                    break;
            }
            return cost;
        }
    }
}
