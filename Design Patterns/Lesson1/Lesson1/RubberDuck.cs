using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class RubberDuck : Duck
    {
        public RubberDuck() // 初始化
        {
            flyBehavior = new FlyNoWay(); // 初始飛行 無法飛行
            quackBehavior = new Squeak(); // 初始叫聲 jiujiu聲
        }
        public void PerformSqueak() // 執行叫聲
        {
            quackBehavior.quack();
        }
        public void PerFormFly() // 執行飛行
        {
            flyBehavior.Fly();
        }
        public override void display()
        {
            Console.WriteLine("I'm a rubber duckie!");
        }
    }
}
