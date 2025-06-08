using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class DecoyDuck // 鴨鳴器不繼承
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public DecoyDuck() // 初始化
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public void PerformFly() // 執行飛行
        {
            flyBehavior.Fly();
        }

        public void PerformQuack() // 執行叫聲
        {
            quackBehavior.quack();
        }

        public void display() // 顯示外觀
        {
            Console.WriteLine("I'm a decoy duck!");
        }
    }
}
