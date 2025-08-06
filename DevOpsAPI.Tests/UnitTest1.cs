using DevOpsAPI.Controllers;

namespace DevOpsAPI.Tests
{
    public class UnitTest1
    {
        private readonly WeatherForecastController _controller = new WeatherForecastController();

        [Fact]
        public void Test1()
        {
            var result = _controller.Get();
            Assert.NotNull(result);
        }
    }
}
