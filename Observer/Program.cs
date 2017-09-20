namespace Observer
{
    class Program
    {
        static void Main()
        {
            var weatherData = new WeatherData();
            weatherData.RegisterObs(new CurrentConditionsDisplay());
            weatherData.RegisterObs(new HeatIndexDisplay());

            weatherData.SetMeasurements(1,1,1);
            weatherData.SetMeasurements(3,3,3);
            weatherData.SetMeasurements(2,2,2);
        }
    }
}
