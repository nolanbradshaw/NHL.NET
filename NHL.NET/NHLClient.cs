using NHL.NET.Endpoints.Conference;
using NHL.NET.Endpoints.Division;
using NHL.NET.Endpoints.Franchise;
using NHL.NET.Endpoints.Players;
using NHL.NET.Endpoints.Standings;
using NHL.NET.Endpoints.Team;
using NHL.NET.Http;
using NHL.NET.Http.Interfaces;

namespace NHL.NET
{
    public class NHLClient : INHLClient
    {
        public ITeamEndpoints Teams { get; }
        public IFranchiseEndpoints Franchises { get; }
        public IDivisionEndpoints Divisions { get; }
        public IStandingsEndpoints Standings { get; }
        public IConferenceEndpoints Conferences { get; }
        public IPlayerEndpoints Players { get; }

        public NHLClient()
        {
            var requester = new Requester();

            Franchises = new FranchiseEndpoints(requester);
            Teams = new TeamEndpoints(requester);
            Divisions = new DivisionEndpoints(requester);
            Standings = new StandingsEndpoints(requester);
            Conferences = new ConferenceEndpoints(requester);
            Players = new PlayerEndpoints(requester);
        }

        public NHLClient(IRequester requester)
        {
            Franchises = new FranchiseEndpoints(requester);
            Teams = new TeamEndpoints(requester);
            Divisions = new DivisionEndpoints(requester);
            Standings = new StandingsEndpoints(requester);
            Conferences = new ConferenceEndpoints(requester);
            Players = new PlayerEndpoints(requester);
        }
    }
}
