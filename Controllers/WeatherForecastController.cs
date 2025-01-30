using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class demoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World!";
        }
    }
}
