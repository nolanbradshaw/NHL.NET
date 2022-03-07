using NHL.NET.Constants;
using NHL.NET.Exceptions;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Player;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Players
{
    public class PlayerEndpoints : IPlayerEndpoints
    {
        private readonly IRequester _requester;
        public PlayerEndpoints(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLPlayerStatsList> GetStatsBySeasonAsync(int playerId, string season, string statsType = StatsTypes.SingleRegularSeason)
        {
            if (string.IsNullOrEmpty(season))
            {
                throw new ArgumentNullException(nameof(season));
            }

            var response = await _requester.GetRequestAsync<NHLPlayerStatsList>($"{Urls.PlayerUrl}/{playerId}/stats?season={season}&stats={statsType}");
            return response;
        }

        public async Task<NHLPlayer> GetByIdAsync(int playerId)
        {
            var response = await _requester.GetRequestAsync<NHLPlayerList>($"{Urls.PlayerUrl}/{playerId}");
            if (response != null && response.Players?.Count > 0)
            {
                return response.Players.First();
            }

            throw new NHLClientException($"No player with id {playerId} could be found.");
        }

        #endregion

        #region Sync

        public NHLPlayer GetById(int playerId)
        {
            var response = _requester.GetRequest<NHLPlayerList>($"{Urls.PlayerUrl}/{playerId}");
            if (response != null && response.Players?.Count > 0)
            {
                return response.Players.First();
            }

            throw new NHLClientException($"No player with id {playerId} could be found.");
        }

        public NHLPlayerStatsList GetStatsBySeason(int playerId, string season, string statsType = StatsTypes.SingleRegularSeason)
        {
            if (string.IsNullOrEmpty(season))
            {
                throw new ArgumentNullException(nameof(season));
            }

            var response =  _requester.GetRequest<NHLPlayerStatsList>($"{Urls.PlayerUrl}/{playerId}/stats?season={season}&stats={statsType}");
            return response;
        }

        #endregion
    }
}
