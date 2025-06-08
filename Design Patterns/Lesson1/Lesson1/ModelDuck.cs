using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class ModelDuck : Duck
    {
        public ModelDuck() // 初始化
        {
            flyBehavior = new FlyNoWay(); // 初始飛行行為 無法飛行
            quackBehavior = new MuteQuack(); // 初始叫聲行為 無聲
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
