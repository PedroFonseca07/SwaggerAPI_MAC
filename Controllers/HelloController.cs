using Microsoft.AspNetCore.Mvc;

namespace SwaggerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from SwaggerApi!");
        }
    }
}