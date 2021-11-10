using NHL.NET.Endpoints.Conference;
using NHL.NET.Endpoints.Division;
using NHL.NET.Endpoints.Franchise;
using NHL.NET.Endpoints.Standings;
using NHL.NET.Endpoints.Team;

namespace NHL.NET
{
    public interface INHLClient
    {
        ITeamEndpoint Teams { get; }
        IFranchiseEndpoint Franchises { get; }
        IDivisionEndpoint Divisions { get; }
        IStandingsEndpoints Standings { get; set; }
        IConferenceEndpoints Conferences { get; set; }
    }
}
