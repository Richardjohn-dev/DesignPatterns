using System;
using System.Collections.Generic;

namespace WeatherStationIObservableT
{

    public class Blah : IObservable<WeatherInfo>
    {
        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            throw new NotImplementedException();
        }
    }

    public class WeatherData : IObservable<WeatherInfo> //Our Concerete Subject
    {
        // A mechanism that allows the provider to keep track of observers
        private List<IObserver<WeatherInfo>> _observers;
        private WeatherInfo _weatherInfo;
        public WeatherData()
        {
            _observers = new();
        }
        public void SetMeasurements(WeatherInfo weatherInfo)
        {
            _weatherInfo = weatherInfo;
            // notify observers
            Console.WriteLine("-------------------------");
            foreach (var observer in _observers)
            {
                observer.OnNext(weatherInfo);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        public double GetTemperature()
        {
            return _weatherInfo.Temperature;
        }
        public double GetHumidity()
        {
            return _weatherInfo.Humidity;
        }
        public double GetPressure()
        {
            return _weatherInfo.Pressure;
        }

                
        // required for IObservable
        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            //An IDisposable implementation that enables the provider to remove observers when notification
            //is complete. Observers receive a reference to the IDisposable implementation from the Subscribe method,
            //so they can also call the IDisposable.Dispose method to unsubscribe before the provider has finished
            //sending notifications.
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherInfo>> _observers;
            private IObserver<WeatherInfo> _observer;

            public Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        //public void EndTransmission()
        //{
        //    foreach (var observer in _observers.ToArray())
        //        if (_observers.Contains(observer))
        //            observer.OnCompleted();
        //    _observers.Clear();
        //}

    }

}
