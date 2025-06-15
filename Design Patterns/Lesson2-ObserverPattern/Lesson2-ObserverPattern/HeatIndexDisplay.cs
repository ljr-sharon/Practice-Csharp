using Lesson2_ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ObserverPattern
{
    public class HeatIndexDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float heatIndex;
        private float humidity;
        private WeatherData weatherData;
        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this); // Register as an observer
        }
        public void Display()
        {
            Console.WriteLine($"Heat index is {heatIndex}");
        }
        private float ComputeHeatIndex(float temp, float rh)
        {
            // Heat index 
            heatIndex = (float)(-42.379 + 2.04901523 * temp +
                10.14333127 * rh - 0.22475541 * temp * rh -
                6.83783e-03 * temp * temp - 5.481717e-02 * rh * rh +
                1.22874e-03 * temp * temp * rh + 8.5282e-04 * temp * rh * rh - 1.99e-06 * temp * temp * rh * rh);
            return heatIndex;
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemperature();
            this.humidity = weatherData.GetHumidity();
            heatIndex = ComputeHeatIndex(temperature, humidity);
            Math.Round(heatIndex, 5);
            Display();
        }
    }
}
