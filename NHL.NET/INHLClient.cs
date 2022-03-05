using NHL.NET.Endpoints.Conference;
using NHL.NET.Endpoints.Division;
using NHL.NET.Endpoints.Franchise;
using NHL.NET.Endpoints.Players;
using NHL.NET.Endpoints.Standings;
using NHL.NET.Endpoints.Team;

namespace NHL.NET
{
    public interface INHLClient
    {
        ITeamEndpoints Teams { get; }
        IFranchiseEndpoints Franchises { get; }
        IDivisionEndpoints Divisions { get; }
        IStandingsEndpoints Standings { get; }
        IConferenceEndpoints Conferences { get; }
        IPlayerEndpoints Players { get; }
    }
}
