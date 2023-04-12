using Microsoft.AspNetCore.Mvc;

namespace NET7_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly ILogger<TimeController> _logger;

        public TimeController(ILogger<TimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTime")]
        public String GetTime()
        {
            return DateTime.Now.ToString();
        }
    }
}