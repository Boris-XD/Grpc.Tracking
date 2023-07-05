using Microsoft.AspNetCore.Mvc;

namespace Grcp.Tracking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrpcClientController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hola");
        }
    }
}
