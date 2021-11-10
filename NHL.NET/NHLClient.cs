using NHL.NET.Endpoints.Conference;
using NHL.NET.Endpoints.Division;
using NHL.NET.Endpoints.Franchise;
using NHL.NET.Endpoints.Standings;
using NHL.NET.Endpoints.Team;
using NHL.NET.Http;

namespace NHL.NET
{
    public class NHLClient
    {
        public ITeamEndpoint Teams { get; }
        public IFranchiseEndpoint Franchises { get; }
        public IDivisionEndpoint Divisions { get; }
        public IStandingsEndpoints Standings { get; set; }
        public IConferenceEndpoints Conferences { get; set; }

        public NHLClient()
        {
            var requester = new Requester();

            Franchises = new FranchiseEndpoint(requester);
            Teams = new TeamEndpoint(requester);
            Divisions = new DivisionEndpoint(requester);
            Standings = new StandingsEndpoints(requester);
            Conferences = new ConferenceEndpoints(requester);
        }
    }
}
