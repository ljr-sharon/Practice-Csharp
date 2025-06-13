using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern
{
    internal class StatisticsDisplay : Interface.Observer, Interface.DisplayElement
    {   // max,min,Avg
        private float lastTemperature;
        private float minTemp;
        private float maxTemp;
        private float avgTemp;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData; // Init
            weatherData.RegisterObserver(this); // 將此畫面注冊為觀察者
        }
        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature : ");
        }

        public void Update(float temp, float humidity, float pressure)
        {

        }
    }
}
