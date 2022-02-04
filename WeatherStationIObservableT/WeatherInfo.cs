using System;

namespace WeatherStationIObservableT
{
    //public class foo : IObservable<WeatherInfo>
    //{
    //    // This is all that the c# implementation uses for the Subject
    //    // Why does it not have notify/register/remove
    //    public IDisposable Subscribe(IObserver<WeatherInfo> observer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //why record / struct.. whats different?
    public record WeatherInfo
    {
        readonly double _temperature;
        readonly double _humidity;
        readonly double _pressure;
        public WeatherInfo(double temp, double humidity, double pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            Console.WriteLine("New weather update just in...");
        }
        public double Temperature { get { return this._temperature; } }
        public double Humidity { get { return this._humidity; } }
        public double Pressure { get { return this._pressure; } }
    }

}
