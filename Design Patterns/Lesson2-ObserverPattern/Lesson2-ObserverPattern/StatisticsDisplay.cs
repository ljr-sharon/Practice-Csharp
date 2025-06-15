using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2_ObserverPattern.Interface;


namespace Lesson2_ObserverPattern
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {   // max,min,Avg
        private float lastTemperature = 0f;
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
            Console.WriteLine($"Avg/Max/Min temperature : {avgTemp:F1}/{maxTemp:F1}/{minTemp:F1}");
        }

        public void Update()
        {
            var temp = weatherData.GetTemperature(); // 取得溫度

            if (lastTemperature == 0)  // 初始化
            {
                minTemp = temp;
                maxTemp = temp;
                avgTemp = temp;
                lastTemperature = temp;
            }
            else
            {
                if (temp < minTemp)
                {
                    minTemp = temp;
                }
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }
                avgTemp = (lastTemperature + temp) / 2; // 簡單平均
                lastTemperature = temp; // 更新最後的溫度
            }
            Display();
        }
    }
}
