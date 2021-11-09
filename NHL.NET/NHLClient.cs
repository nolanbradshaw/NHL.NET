using NHL.NET.Endpoints.Franchise;
using NHL.NET.Http;

namespace NHL.NET
{
    public class NHLClient
    {
        public IFranchiseEndpoint Franchise { get; }
        public NHLClient()
        {
            var requester = new Requester();

            Franchise = new FranchiseEndpoint(requester);
        }
    }
}
