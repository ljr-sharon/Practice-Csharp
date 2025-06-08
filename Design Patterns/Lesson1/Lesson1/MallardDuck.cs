using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            flyBehavior = new FlyWithWings(); // 初始飛行 翅膀飛行
            quackBehavior = new Quack(); // 初始叫聲 嘎嘎聲
        }


        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}
