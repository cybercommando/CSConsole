using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IoTDevice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return new OkObjectResult("Welcome");
        }
    }
}
