using NHL.NET.Endpoints.Franchise;
using NHL.NET.Endpoints.Team;
using NHL.NET.Http;

namespace NHL.NET
{
    public class NHLClient
    {
        public ITeamEndpoint Team { get; }
        public IFranchiseEndpoint Franchise { get; }
        public NHLClient()
        {
            var requester = new Requester();

            Franchise = new FranchiseEndpoint(requester);
            Team = new TeamEndpoint(requester);
        }
    }
}
