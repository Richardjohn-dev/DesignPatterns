using System;
using System.Collections.Generic;

namespace WeatherMonitorObserver
{
    class Program
    {
        // Chapter 2 Weather Observer Chapter
        static void Main(string[] args)
        {



            Console.ReadLine();
        }

        
    }


    public class WeatherData : ISubject
    {
        private  List<IObserver> _observers;
        private  float _temperature;
        private  float _humidity;
        private  float _pressure;

        public WeatherData()
        {
            _observers = new();
        }


        // from interface
        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }


        // class methods
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }

    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private float _temperature;
        private float _humidity;
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions {_temperature} degrees and {_humidity}% humidity");
        }
        void IObserver.Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }
    }

    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private float _currentPressure = 29.92f;
        private float _lastPressure;
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
        void IObserver.Update(float temp, float humidity, float pressure)
        {
            this._lastPressure = _currentPressure;
            this._currentPressure = pressure;

            Display();
        }
    }

    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
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
        void IObserver.Update(float temp, float humidity, float pressure)
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

    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();

    }

    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        void Display();
    }
}
