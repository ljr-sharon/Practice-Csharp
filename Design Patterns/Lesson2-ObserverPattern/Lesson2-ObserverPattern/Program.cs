namespace Lesson2_ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            // 建立三個畫面 當前數據 avg、min、max 預測數據
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            // 模擬更新氣象數據
            weatherData.SetMeasurements(80,65,30.4f);
            weatherData.SetMeasurements(82,70,29.2f);
            weatherData.SetMeasurements(78,90,29.2f);

            Console.ReadLine();
        }

    }
}
