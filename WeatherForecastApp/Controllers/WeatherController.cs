using System.Web.Mvc;
using WeatherForecastApp.Services;


namespace WeatherForecastApp.Controllers
{
    public class WeatherController : Controller
    {
        private IRssReader _rssReader;

        public WeatherController(IRssReader rssReader)
        {
            _rssReader = rssReader;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetWeather(int woeid, char degreesUnits)
        {
            var result = _rssReader.GetWeatherRss(woeid, degreesUnits);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetWeatherPartial(int woeid, char degreesUnits)
        {
            var result = _rssReader.GetWeatherRss(woeid, degreesUnits);
            return PartialView("ForecastPartial", result);
        }

    }
}
