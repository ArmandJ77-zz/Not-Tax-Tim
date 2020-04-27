using Microsoft.AspNetCore.Mvc;
using System;

namespace NotTaxTim.Api.Controllers
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
