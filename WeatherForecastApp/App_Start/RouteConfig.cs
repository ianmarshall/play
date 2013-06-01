using System.Web.Mvc;
using System.Web.Routing;

namespace WeatherForecastApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           "Weather",
           "Weather/GetWeather/{woeid}/{degreesUnits}",
           new { controller = "Weather", action = "GetWeather", woeid = 44418, degreesUnits = 'c' }
       );

            routes.MapRoute(
        "WeatherPartial",
        "Weather/GetWeatherPartial/{woeid}/{degreesUnits}",
        new { controller = "Weather", action = "GetWeatherPartial", woeid = 44418, degreesUnits = 'c' }
    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}