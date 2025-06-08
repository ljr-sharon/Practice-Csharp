using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public Duck() // 初始化
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }
        public abstract void display(); // 外觀
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.quack();
        }
        public void SetFlyBehavior(IFlyBehavior fb) // 設定飛行行為
        {
            flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb) // 設定叫聲行為
        {
            quackBehavior = qb;
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
