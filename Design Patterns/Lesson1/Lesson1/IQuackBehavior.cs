using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public interface IQuackBehavior
    {
        public void quack();
    }
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
