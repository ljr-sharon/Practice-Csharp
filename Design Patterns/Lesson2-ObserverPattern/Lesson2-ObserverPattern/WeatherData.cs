using Lesson2_ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern
{
    public class WeatherData : Interface.Subject
    {
        private List<Interface.Observer> observers; // 存放觀察者
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<Interface.Observer>(); // 初始化觀察者列表

        }
        // 
        public float GetTemperature() { return 0.0f; }
        public float GetHumidity() { return 0.0f; }
        public float GetPressure() { return 0.0f; }
        public void measurementsChanged()
        {
            NotifyObservers(); // 當數據改變時 通知所有觀察者
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer); // 添加觀察者
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer); // 移除觀察者
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(temperature, humidity, pressure); // 通知所有觀察者

            }
        }
    }
}
