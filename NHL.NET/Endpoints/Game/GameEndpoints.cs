using NHL.NET.Constants;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Game;
using System;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Game
{
    public class GameEndpoints : IGameEndpoints
    {
        private readonly IRequester _requester;
        public GameEndpoints(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLGameBoxscore> GetBoxscoreAsync(string gameId)
        {
            if (string.IsNullOrEmpty(gameId))
            {
                throw new ArgumentNullException(nameof(gameId));
            }

            var response = await _requester.GetRequestAsync<NHLGameBoxscore>($"{Urls.GameUrl}/{gameId}/boxscore");
            return response;
        }

        #endregion

        #region Sync

        public NHLGameBoxscore GetBoxscore(string gameId)
        {
            if (string.IsNullOrEmpty(gameId))
            {
                throw new ArgumentNullException(nameof(gameId));
            }

            var response = _requester.GetRequest<NHLGameBoxscore>($"{Urls.GameUrl}/{gameId}/boxscore");
            return response;
        }

        #endregion
    }
}
