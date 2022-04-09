using Microsoft.Extensions.Logging;
using Moq;
using WebApi.Controllers;
using Xunit;

namespace UnitTest
{
    public class WeatherForecastControllerTest
    {
        private readonly WeatherForecastController _controller;
        Mock<ILogger<WeatherForecastController>> _logger;

        public WeatherForecastControllerTest()
        {
            _logger = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_logger.Object);
        }

        [Fact]
        public void Test1()
        {
            var result = _controller.Get();
            Assert.NotNull(result);
        }
    }
}