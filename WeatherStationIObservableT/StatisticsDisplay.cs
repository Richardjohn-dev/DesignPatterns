using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherStationIObservableT
{
    public class StatisticsDisplay : IObserver<WeatherInfo>, IDisplayElement  //Our Concerete Observer
    {
        private readonly List<WeatherInfo> _weatherInfos;
        private IDisposable _unsubscriber;

        public StatisticsDisplay(IObservable<WeatherInfo> subject)
        {
            _weatherInfos = new List<WeatherInfo>();
            Subscribe(subject);
        }

        public virtual void Subscribe(IObservable<WeatherInfo> subject)
        {
            _unsubscriber = subject.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }


        // iObserver
        public void OnNext(WeatherInfo weatherInfo)
        {
            _weatherInfos.Add(weatherInfo);
            Display();
        }
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }


        // IDisplay
        public void Display()
        {
            double minTemp = _weatherInfos.Min(x => x.Temperature);
            double maxTemp = _weatherInfos.Max(x => x.Temperature);
            double avgTemp = _weatherInfos.Average(x => x.Temperature);
            Console.WriteLine("Latest Weather Statistics are...");
            Console.WriteLine($"Avg/Max/Min temperature = {avgTemp} / {maxTemp} / {minTemp}");
        }
    }

}
