using System.Drawing;
using System.Threading.Channels;

namespace Lesson3_DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage blacktea = new RedTea();
            blacktea.SetSize(Size.Tall);
            Console.WriteLine(blacktea.GetDescription() + " : $" + blacktea.cost());

            Beverage greentea = new GreenTea();
            greentea.SetSize(Size.Middle);
            Console.WriteLine(greentea.GetDescription() + " : $" + greentea.cost());

            while (true)
            {
                Beverage blacktea2 = new RedTea();
                string Input = Console.ReadLine();
                switch (Input)
                {
                    case "l":
                        blacktea2.SetSize(Size.Tall);
                        break;
                    case "m":
                        blacktea2.SetSize(Size.Middle);
                        break;
                    case "s":
                        blacktea2.SetSize(Size.Small);
                        break;
                }
                blacktea2 = new Milk(blacktea2);
                blacktea2 = new Bubble(blacktea2);
                blacktea2 = new CreamFoam(blacktea2);
                Console.WriteLine(blacktea2.GetDescription() + " : $" + blacktea2.cost());
            }



        }
    }
}
