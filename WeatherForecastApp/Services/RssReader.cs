using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeatherForecastApp.Models;

namespace WeatherForecastApp.Services
{
    public class RssReader : IRssReader
    {
        private const string Url = "http://weather.yahooapis.com/forecastrss?w=";

        public rss GetWeatherRss(int woeid, char degreesUnits)
        {
            rss rssFeed;
            try
            {
                var ser = new XmlSerializer(typeof(rss));

                using (var reader = XmlReader.Create(Url + woeid + "&u=" + degreesUnits))
                {
                    rssFeed = (rss)ser.Deserialize(reader);
                }
            }
            catch
            {
                rssFeed = null;
            }
            return rssFeed;
        }

        public static IEnumerable<Rss> GetRssFeed()
        {
            var feedXml = XDocument.Load(Url);

            var feeds = from feed in feedXml.Descendants("item")
                        select new Rss
                        {
                            Title = feed.Element("title").Value,
                            Link = feed.Element("link").Value,
                            Description = Regex.Match(feed.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value
                        };
            return feeds;

        }


        public static WeatherModel GetWeatherFeed()
        {
            var model = new WeatherModel();
            using (var reader = XmlReader.Create(Url))
            {
                var rssData = SyndicationFeed.Load(reader);
                model.WeatherFeed = rssData;
            }
            return model;


        }



    }
}