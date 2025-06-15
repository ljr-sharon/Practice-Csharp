namespace Lesson2_ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            // 建立四個畫面 當前數據 avg、min、max 預測數據 酷熱指數
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            // 模擬更新氣象數據
            while (true)
            {
                Console.WriteLine("Press Enter to update weather data or type 'exit' to quit:");
                string input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                { break; }

                // 模擬隨機氣象數據
                Random random = new Random();
                float temperature = random.Next(60, 100);
                float humidity = random.Next(0, 100);
                float pressure = 29.92f + (float)(random.NextDouble() * 0.5 - 0.25); // 模擬壓力

                weatherData.SetMeasurements(temperature, humidity, pressure);
            }
            //weatherData.SetMeasurements(80,65,30.4f);
            //weatherData.SetMeasurements(82,70,29.2f);
            //weatherData.SetMeasurements(78,90,29.2f);

            //Console.ReadLine();
        }

    }
}
