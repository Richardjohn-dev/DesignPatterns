using System.Collections.Generic;

namespace WeatherStationRefactored
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers; // our observers
        private double _temperature, _humidity, _pressure;
        public WeatherData()
        {
            _observers = new();
        }
        // Subject recieves data the same
        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }
        public void RegisterObserver(IObserver o) => _observers.Add(o);
        public void RemoveObserver(IObserver o) => _observers.Remove(o);


        // ****** Updates
        // Refactored so Observers can PULL from Subject(this).
public void NotifyObservers()
    => _observers.ForEach(o => o.Update());
        // Notice we are only calling Update(), no data is being sent down.

// Getters:
// Functions observer(s) call to PULL the updates down from Subject(this).
public double GetTemperature() => _temperature;
public double GetHumidity() => _humidity;
public double GetPressure() => _pressure;

    }
}
