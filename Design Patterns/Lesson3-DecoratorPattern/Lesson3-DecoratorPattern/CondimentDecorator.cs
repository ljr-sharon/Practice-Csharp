using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DecoratorPattern
{
    public abstract class CondimentDecorator:Beverage // 調味品裝飾器
    {
        Beverage beverage;
        public abstract override string GetDescription();
        public override Size GetSize()
        {
            Size size = base.GetSize();
            return size;
        }

    }
}
