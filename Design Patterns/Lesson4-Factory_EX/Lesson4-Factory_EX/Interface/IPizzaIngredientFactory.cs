using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Factory_EX.Interface
{
    internal interface IPizzaIngredientFactory // 食材工廠 每種食材對應一個新類別
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clam CreateClam();

    }

    public class Clam
    {
    }

    public class Pepperoni
    {
    }

    public class Veggies
    {
    }

    public class Cheese
    {
    }

    public class Sauce
    {
    }

    public class Dough
    {
    }
}
