using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgentTests
{
    public class HddMetricsControllerTests
    {
        private HddMetricsController _hddMetricsController;

        public HddMetricsControllerTests()
        {
            _hddMetricsController = new HddMetricsController();
        }

        [Fact]
        public void GetHddMetrics_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            var result = _hddMetricsController.GetHddMetrics(fromTime, toTime);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
