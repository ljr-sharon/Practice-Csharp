using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2_ObserverPattern.Interface;


namespace Lesson2_ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData; // Init
            weatherData.RegisterObserver(this); // 將此畫面注冊為觀察者
        }
        public void Display()
        {
            Console.WriteLine($"CurrentConditions : {temperature:F1} F degrees and {humidity} % humidity");
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemperature();
            this.humidity = weatherData.GetHumidity();
            Display();
        }
    }
}
