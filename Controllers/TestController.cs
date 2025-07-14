using Microsoft.AspNetCore.Mvc;

namespace TaskManagerApi.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok("Test route is working");
        }
    }
}
