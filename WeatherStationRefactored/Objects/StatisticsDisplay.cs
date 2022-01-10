using System;

namespace WeatherStationRefactored
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private double _maxTemp = 0.0f;
        private double _minTemp = 200;
        private double _tempSum = 0.0f;
        private int _numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = { _tempSum / _numReadings } / { _maxTemp } / { _minTemp }");
        }

        public void Update()
        {
            // pull from subject
            var latestTemp = _weatherData.GetTemperature();
          
            _tempSum += latestTemp;
            _numReadings++;         

            if (latestTemp > _maxTemp)
                _maxTemp = latestTemp;    

            if (latestTemp < _minTemp)
                _minTemp = latestTemp;

            Display();
        }

    }
}
