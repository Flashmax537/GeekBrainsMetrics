using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgentTests
{
    public class RamMetricsControllerTests
    {
        private RamMerticsController _ramMetricsController;

        public RamMetricsControllerTests()
        {
            _ramMetricsController = new RamMerticsController();
        }

        [Fact]
        public void GetRamMertics_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            var result = _ramMetricsController.GetRamMertics(fromTime, toTime);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
