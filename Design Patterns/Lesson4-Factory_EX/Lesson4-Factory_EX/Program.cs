namespace Lesson4_Factory_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose your Pizza Store:\n" +
                    "[1].NYPizzaStore" +
                    "[2].ChicagoPizzaStore" +
                    "[3].DIYPizzaStore");

                PizzaStore store;
                //PizzaStore nyStore = new NYPizzaStore();
                //PizzaStore ccgStore = new ChicagoPizzaStore();
                string input = Console.ReadLine();
                int pressID = int.Parse(input);
                switch (pressID)
                {
                    case 1:
                        store = new NYPizzaStore();
                        break;
                    case 2:
                        store = new ChicagoPizzaStore();
                        break;
                    case 3:
                        store = new DIYPizzaStore();
                        break;
                    default:
                        store = null;
                        Console.WriteLine("Choose Again!");
                        continue;
                }
                Console.WriteLine("Choose your Order:\n" +
                    "[1].cheese" +
                    "[2].pineapple" +
                    "[3].back to store");

                string input2 = Console.ReadLine();
                int orderID=int.Parse(input2);
                string order;
                switch (orderID)
                {
                    case 1:
                        order = "cheese";
                        break;
                    case 2:
                        order = "pineapple";
                        break;
                    default:
                        Console.WriteLine("back to store");
                        continue;
                }
                Pizza pizza = store.OrderPizza(order);
                Console.WriteLine("Ordered a " + pizza.GetName()+"\n");
            }
        }
    }
}
