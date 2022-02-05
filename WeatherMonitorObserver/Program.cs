using System;
using System.Collections.Generic;

namespace WeatherMonitorObserver
{
    class Program
    {
        // Chapter 2 Weather Observer Chapter
        static void Main(string[] args)
        {

            WeatherData weatherData = new();

            CurrentConditionsDisplay currentConditions = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);
            HeatIndexDisplay heatIndexDisplay = new(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);

            weatherData.RegisterObserver(heatIndexDisplay);

            weatherData.SetMeasurements(78, 90, 29.2f);
           
            Console.ReadLine();
        }

        
    }
      
public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers; // our observers
    private double _temperature, _humidity, _pressure; 
    // the data our observers wants

    public WeatherData()
    {
        _observers = new();
    }        
    // Subject recieves new data        
    public void SetMeasurements(double temp, double humidity, double pressure)
    {
        this._temperature = temp;
        this._humidity = humidity;
        this._pressure = pressure;
        // and then sends out updates to its observers/subscribers
        NotifyObservers();
    }

    public void NotifyObservers()
            => _observers.ForEach(o => o.Update(_temperature, _humidity, _pressure));
    // This calls the Update() method from out Observers shared interface.
    public void RegisterObserver(IObserver o) => _observers.Add(o);
    public void RemoveObserver(IObserver o) => _observers.Remove(o);
}

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
        void IObserver.Update(double temp, double humidity, double pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }
    }

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
        void IObserver.Update(double temp, double humidity, double pressure)
        {
            this._lastPressure = _currentPressure;
            this._currentPressure = pressure;

            Display();
        }
    }

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
        void IObserver.Update(double temp, double humidity, double pressure)
        {
            _tempSum += temp;
            _numReadings++;

            if (temp > _maxTemp)
            {
                _maxTemp = temp;
            }

            if (temp < _minTemp)
            {
                _minTemp = temp;
            }

            Display();
        }
    }

    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private double _heatIndex = 0.0f;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Heat index is " + _heatIndex);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            _heatIndex = ComputeHeatIndex(temp, humidity);
            Display();
        }
        private static double ComputeHeatIndex(double t, double rh)
        {
            double index = (16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                            + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                            + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                            (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                            (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                            (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                            0.000000000843296 * (t * t * rh * rh * rh)) -
                           (0.0000000000481975 * (t * t * t * rh * rh * rh));
            return index;
        }
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }

    public interface IDisplayElement
    {
        void Display();
    }

}
