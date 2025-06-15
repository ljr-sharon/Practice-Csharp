using Lesson2_ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers; // 存放觀察者
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<Observer>(); // 初始化觀察者列表

        }
        
        public float GetTemperature() { return temperature; }
        public float GetHumidity() { return humidity; }
        public float GetPressure() { return pressure; }
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
                observer.Update(); // 通知所有觀察者更新

            }
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
