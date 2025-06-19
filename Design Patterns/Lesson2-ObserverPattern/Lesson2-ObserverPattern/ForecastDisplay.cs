using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2_ObserverPattern.Interface;


namespace Lesson2_ObserverPattern
{
    public class ForecastDisplay : Observer, DisplayElement
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
            //if (currentPressure > lastPressure)
            //{
            //    Console.WriteLine("Forecast : Improving weather on the way!");
            //}
            //else if (currentPressure == lastPressure)
            //{
            //    Console.WriteLine("Forecast : More of the same");
            //}
            //else  // currentPressure < lastPressure
            //{
            //    Console.WriteLine("Forecast : Watch out for cooler, rainy weather");
            //}

            string forecast = currentPressure > lastPressure ? "Improving weather on the way!" :
                              currentPressure == lastPressure ? "More of the same" :
                              "Watch out for cooler, rainy weather";
            Console.WriteLine("Forecast : " + forecast);

            //switch (true)
            //{
            //    case var _ when currentPressure > lastPressure:
            //        Console.WriteLine("Forecast : Improving weather on the way!");
            //        break;
            //    case var _ when currentPressure == lastPressure:
            //        Console.WriteLine("Forecast : More of the same");
            //        break;
            //    case var _ when currentPressure < lastPressure:
            //        Console.WriteLine("Forecast : Watch out for cooler, rainy weather");
            //        break;
            //}

        }

        public void Update()
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.GetPressure();
            Display();
        }
    }
}
