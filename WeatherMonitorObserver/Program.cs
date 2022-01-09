using System;

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
