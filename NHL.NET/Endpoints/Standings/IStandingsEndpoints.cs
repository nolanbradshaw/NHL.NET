using NHL.NET.Constants;
using NHL.NET.Models.Standings;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Standings
{
    public interface IStandingsEndpoints
    {
        Task<NHLStandings> GetCurrentAsync(string standingsType = StandingsTypes.RegularSeason);

        Task<NHLStandings> GetBySeasonAsync(string season, string standingsType = StandingsTypes.RegularSeason);

        NHLStandings GetBySeason(string season, string standingsType = StandingsTypes.RegularSeason);

        NHLStandings GetCurrent(string standingsType = StandingsTypes.RegularSeason);
    }
}
