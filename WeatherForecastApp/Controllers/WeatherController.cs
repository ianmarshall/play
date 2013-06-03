using System.Configuration;
using System.Web.Mvc;
using WeatherForecastApp.Services;


namespace WeatherForecastApp.Controllers
{
     /// <summary>
    /// Main weather controller
    /// </summary>
    public class WeatherController : Controller
    {
        private IRssReader _rssReader;

        /// <summary>
        /// Initializes a new instance of the <see cref="IRssReader"/> class using DI
        /// </summary>
        /// <param name="rssReader"></param>
        public WeatherController(IRssReader rssReader)
        {
            _rssReader = rssReader;
        }

        /// <summary>
        /// Returns main Index view including Refresh Interval setting
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.RefreshInterval = ConfigurationManager.AppSettings["RefreshInterval"];
            return View();
        }

        /// <summary>
        /// Returns a partial view of the latest weather foreacast based on inputs
        /// </summary>
        /// <param name="woeid"></param>
        /// <param name="degreesUnits"></param>
        /// <returns></returns>
        public ActionResult GetWeatherPartial(int woeid, char degreesUnits)
        {
            var result = _rssReader.GetWeatherRss(woeid, degreesUnits);
            if (result == null || result.channel[0].title.ToLower().Contains("error"))
            {
                return Content("<h2>Error - please try again.." +
                               "</h2>");
            }

            return PartialView("ForecastPartial", result);

        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="woeid"></param>
        /// <param name="degreesUnits"></param>
        /// <returns></returns>
        public JsonResult GetWeather(int woeid, char degreesUnits)
        {
            var result = _rssReader.GetWeatherRss(woeid, degreesUnits);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
