using Microsoft.AspNetCore.Mvc;
using SharpCode.PerformanceCounterApi.Persistence.Model;

namespace SharpCode.PerformanceCounterApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerformanceController : ControllerBase
    {
        private readonly ILogger<PerformanceController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public PerformanceController(ILogger<PerformanceController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [HttpPost(Name = "SendValue")]
        public IActionResult SendValue(int sensorId, ValueModel valueModel) 
        {
            return Ok();
        }
    }
}
