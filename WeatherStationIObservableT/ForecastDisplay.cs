using System;

namespace WeatherStationIObservableT
{
    public class ForecastDisplay : IObserver<WeatherInfo>, IDisplayElement
    {     
        private double _currentPressure = 29.92f;
        private double _lastPressure;
        private IDisposable _unsubscriber;

        public ForecastDisplay(IObservable<WeatherInfo> subject)
        {
            Subscribe(subject);
        }

        public void Subscribe(IObservable<WeatherInfo> observer)
        {
            _unsubscriber = observer.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        // iObserver
        public void OnCompleted()
        {
            // Do nothing.
        }

        public void OnError(Exception error)
        {
            // Do nothing.
        }

        public void OnNext(WeatherInfo weatherInfo)
        {
           
            this._lastPressure = _currentPressure;
            this._currentPressure = weatherInfo.Pressure;
            Display();
        }

        // IDisplay
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("The Forecast Is: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same...");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }


    }

}
