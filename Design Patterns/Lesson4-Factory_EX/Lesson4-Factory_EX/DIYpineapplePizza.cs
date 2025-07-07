namespace Lesson4_Factory_EX
{
    internal class DIYpineapplePizza : Pizza
    {
        public DIYpineapplePizza()
        {
            name = "Hawaii Pizza has ketchup & pineapple";
            dough = "Thin Crust Dough";
            sauce = "Tomato Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}