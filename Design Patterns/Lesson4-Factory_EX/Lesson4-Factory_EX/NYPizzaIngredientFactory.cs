using Lesson4_Factory_EX.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Factory_EX
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public Clam CreateClam()
        {
            throw new NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
