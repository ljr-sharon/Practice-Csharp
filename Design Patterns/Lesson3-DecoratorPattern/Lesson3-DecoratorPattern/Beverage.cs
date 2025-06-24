using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DecoratorPattern
{
    public enum Size
    {
        Tall,
        Middle,
        Small,
        None
    }
    public abstract class Beverage // 飲料抽象類別
    {
        public string description;
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract double cost();

       
        Size size = Size.Tall;

        public void SetSize(Size size)
        {
            this.size = size;
        }
        public virtual Size GetSize()
        {
            return this.size;
        }
    }
}
