using System;

namespace WeatherStationRefactored
{
    // Observer - defines a one-to-many dependancy between objects
    // so what when one object changes state, all its dependants are notified and udpated automatically.

    // Observer bullet points
    // The Observer Pattern defines a one-to-many relationship between objects.
    // Subjects update Observers using a common interface.
    // Observers of any concrete type can participate in the pattern as long as they implement the Observer interface.
    // Observers are loosely coupled in that the Subject knows nothing about them, other than that they implement the Observer interface.
    // You can push or pull data from the Subject when using the pattern(pull is considered more “correct”).
    // Swing makes heavy use of the Observer Pattern, as do many GUI frameworks.
    // You’ll also find the pattern in many other places, including RxJava, JavaBeans, and RMI,
    //      as well as in other language frameworks, like Cocoa, Swift, and JavaScript events.
    // The Observer Pattern is related to the Publish/Subscribe Pattern, which is for more complex
    //      situations with multiple Subjects and/or multiple message types.
    // The Observer Pattern is a commonly used pattern, and we’ll see it again when we learn about Model-View-Controller.

    class Program
    {     
       
    static void Main(string[] args)
        {

            WeatherData weatherData = new();

            CurrentConditionsDisplay currentConditions = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);
            HeatIndexDisplay heatIndexDisplay = new(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.RemoveObserver(heatIndexDisplay);//testing
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadLine();
        }

        // Part 2 - updating our Weather Observer App for new changes
        // Updating our weather station to push/pull 

        // Rather than our Subject PUSHING updated to all observers
        // We are now going to allow OBservers to PULL the data they need.
    }
}
