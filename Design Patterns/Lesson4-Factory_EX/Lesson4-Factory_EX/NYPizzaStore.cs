using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Factory_EX
{
    internal class NYPizzaStore : PizzaStore
    {

        public override Pizza CreatePizza(string type)
        {
            int id = GetTypeID(type);
            switch (id)
            {
                case 1:
                    return new NYStyleCheesePizza();
                case 2:
                    return new NYStyleVeggiePizza();
                case 3:
                    return new NYStyleClamPizza();
                case 4:
                    return new NYStylePepperoniPizza();
                default:
                    return null;
            }
        }
        public int GetTypeID(string type)
        {
            switch (type)
            {
                case "cheese":
                    return 1;
                case "veggie":
                    return 2;
                case "clam":
                    return 3;
                case "pepperoni":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
