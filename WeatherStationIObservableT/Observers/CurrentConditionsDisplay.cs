using System;

namespace WeatherStationIObservableT
{
    public class CurrentConditionsDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private IDisposable _unsubscriber;
        private WeatherInfo _weatherInfo;

        public CurrentConditionsDisplay(IObservable<WeatherInfo> subject)
        {
            Subscribe(subject);
        }
        // why do we need to return an idisposable unsubscriber? 
        // why virtual?

        // in C# implementation, why is subscribe and unsubscribe not built in requirement for observers?
        public virtual void Subscribe(IObservable<WeatherInfo> subject)
        {
            if (subject != null)
                _unsubscriber = subject.Subscribe(this);
        }
        public void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        // required from IObserver
        public void OnNext(WeatherInfo weatherInfo) // Update
        {
            _weatherInfo = weatherInfo;
            Display();
        }

        // from our IDisplayElement
        public void Display()
        {            
            Console.WriteLine(
                $"Current conditions: {_weatherInfo.Temperature} F degrees and {_weatherInfo.Humidity} % humidity");
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
    }

}
