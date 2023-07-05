using Grpc.Net.Client;
using Grpc.Tracking;
using Microsoft.AspNetCore.Mvc;

namespace Grcp.Tracking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrpcClientController : ControllerBase
    {
        private readonly Greeter.GreeterClient _greeterClient;

        public GrpcClientController()
        {
            var url = "https://localhost:7181";
            var channel = GrpcChannel.ForAddress(url);
            _greeterClient = new Greeter.GreeterClient(channel);
        }

        [HttpGet("{nombre}")]
        public async Task<IActionResult> Get(string nombre)
        {
            var helloRequest = new HelloRequest()
            {
                Name = nombre,
            };

            var result = await _greeterClient.SayHelloAsync(helloRequest);

            return Ok(result);
        }
    }
}
