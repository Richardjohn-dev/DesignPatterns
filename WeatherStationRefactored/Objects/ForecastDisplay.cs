using System;

namespace WeatherStationRefactored
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private double _currentPressure = 29.92f;
        private double _lastPressure;
        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }

        }

        public void Update()
        {
            _lastPressure = _currentPressure;
            _currentPressure = _weatherData.GetPressure();
            Display();
        }
    }
}
