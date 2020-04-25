using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController: ControllerBase
    {
        [HttpGet("/health")]
        public IActionResult Health()
        {
            return Ok($"Build #{Environment.GetEnvironmentVariable("VERSION")}");
        }
    }
}
