using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Factory_EX
{
    internal abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
    }
}
