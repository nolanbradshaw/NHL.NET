using NHL.NET.Models.Game;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Game
{
    public interface IGameEndpoints
    {
        Task<NHLGameBoxscore> GetBoxscoreAsync(string gameId);
        NHLGameBoxscore GetBoxscore(string gameId);
    }
}
