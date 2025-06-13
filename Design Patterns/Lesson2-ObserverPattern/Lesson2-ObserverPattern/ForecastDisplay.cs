using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern
{
    internal class ForecastDisplay : Interface.Observer, Interface.DisplayElement
    {   // 預測
        private float currentPressure=29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData; // Init
            weatherData.RegisterObserver(this); // 將此畫面注冊為觀察者
        }
        public void Display()
        {
            // 畫面程式
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.GetPressure();
            Display();
        }
    }
}
