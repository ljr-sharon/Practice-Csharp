using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern.Interface
{
    public interface Subject
    {
        public void RegisterObserver(Observer observer); // 接收觀察者引數
        public void RemoveObserver(Observer observer);
        public void NotifyObservers();
    }
}
