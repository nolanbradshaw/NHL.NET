using NHL.NET.Constants;
using NHL.NET.Models.Player;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Players
{
    public interface IPlayerEndpoints
    {
        Task<NHLPlayer> GetByIdAsync(int playerId);
        NHLPlayer GetById(int playerId);

        Task<NHLPlayerStatsList> GetStatsBySeasonAsync(int playerId, string season, string statsType = StatsTypes.SingleRegularSeason);

        NHLPlayerStatsList GetStatsBySeason(int playerId, string season, string statsType = StatsTypes.SingleRegularSeason);
    }
}
