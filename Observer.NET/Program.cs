namespace Observer.NET
{
    class Program
    {
        static void Main()
        {
            var weatherData = new WeatherData();
            weatherData.Subscribe(new CurrentConditionsDisplay());

            weatherData.SetMeasurements(1, 1, 1);
            weatherData.SetMeasurements(3, 3, 3);
            weatherData.SetMeasurements(2, 2, 2);
            weatherData.Dispose();
        }
    }
}
