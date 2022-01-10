using System;

namespace WeatherStationRefactored
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData; // not used, but probably used in the future to unregister
        private double _temperature;
        private double _humidity;
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions {_temperature} degrees and {_humidity}% humidity");
        }

        // modification
        public void Update()
        {
            // this is where we PULL from the subject
            _temperature = _weatherData.GetTemperature();
            _humidity = _weatherData.GetHumidity();
            Display();
        }
       
    }
}
