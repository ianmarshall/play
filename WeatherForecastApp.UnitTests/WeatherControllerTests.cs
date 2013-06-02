
using NUnit.Framework;
using Rhino.Mocks;
using WeatherForecastApp.Controllers;
using WeatherForecastApp.Services;

namespace WeatherForecastApp.UnitTests
{
    [TestFixture]
    // TODO: complete more tests
    public class WeatherControllerTests
    {
        [Test]
        public void CanGetWeatherPartialReturn()
        {
            // Arrange
            var mockRssReader = MockRepository.GenerateStub<IRssReader>();
            var weatherController = new WeatherController(mockRssReader);

            // Act
            var result = weatherController.GetWeatherPartial(0, 'c');

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
