using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern
{
    public class CurrentConditionsDisplay : Interface.Observer, Interface.DisplayElement
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
            Console.WriteLine($"CurrentConditions : {temperature} ; F degrees and {humidity} % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
