using System.Collections.Generic;

namespace WeatherStationRefactored
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;
        public WeatherData()
        {
            _observers = new();
        }
              
        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                // Modification -observers now pulling these readings
                // o.Update(_temperature, _humidity, _pressure); 
                o.Update();
            }
        }

        public void RegisterObserver(IObserver o) => _observers.Add(o);
        public void RemoveObserver(IObserver o) => _observers.Remove(o);
      

        // observers pulling from these
        public double GetTemperature() => _temperature;
        public double GetHumidity() => _humidity;    
        public double GetPressure() => _pressure;
     

        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        // probably redundant now..
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
