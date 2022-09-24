﻿using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgentTests
{
    public class DotNetMetricsControllerTests
    {
        private DotNetMetricsController _dotNetMetricsController;

        public DotNetMetricsControllerTests()
        {
            _dotNetMetricsController = new DotNetMetricsController();
        }

        [Fact]
        public void GetDotNetMetrics_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            var result = _dotNetMetricsController.GetDotNetMetrics(fromTime, toTime);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
