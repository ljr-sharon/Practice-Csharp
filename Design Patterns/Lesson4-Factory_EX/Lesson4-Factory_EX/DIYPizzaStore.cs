namespace Lesson4_Factory_EX
{
    internal class DIYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            int id = GetTypeID(type);
            switch (id)
            {
                case 1:
                    return new DIYpineapplePizza();
                case 2:
                    return new DIYpotatoPizza();
                case 3:
                    return new DIYbananaPizza();
                case 4:
                    return new DIYchocolatePizza();
                default:
                    return null;
            }
        }
        public int GetTypeID(string type)
        {
            switch (type)
            {
                case "pineapple":
                    return 1;
                case "potato":
                    return 2;
                case "banana":
                    return 3;
                case "chocolate":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}