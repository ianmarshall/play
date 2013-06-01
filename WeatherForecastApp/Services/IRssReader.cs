namespace WeatherForecastApp.Services
{
    public interface IRssReader
    {
        rss GetWeatherRss(int woeid, char degreesUnits);
    }
}