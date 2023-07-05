using Grpc.Core;

namespace Grpc.Tracking.Services
{
    public class GoodByeService : GoodBye.GoodByeBase
    {
        public override Task<ByeReply> SayGoodBye(ByeRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ByeReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
