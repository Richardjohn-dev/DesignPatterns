namespace WeatherStationIObservableT
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
          
            weatherData.SetMeasurements(new WeatherInfo(80, 65, 30.4f));
            weatherData.SetMeasurements(new WeatherInfo(82, 70, 29.2f));
            weatherData.SetMeasurements(new WeatherInfo(78, 90, 29.2f));
        
            forecastDisplay.Unsubscribe();
            statisticsDisplay.Unsubscribe();

            var heatIndex = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(new WeatherInfo(62, 90, 29.2f));
        }


    }

}
