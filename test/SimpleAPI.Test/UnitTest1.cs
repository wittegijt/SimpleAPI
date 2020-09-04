using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Something", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
