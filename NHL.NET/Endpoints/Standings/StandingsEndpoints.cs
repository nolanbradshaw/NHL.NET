using NHL.NET.Constants;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Standings;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Standings
{
    public class StandingsEndpoints : IStandingsEndpoints
    {
        private readonly IRequester _requester;
        public StandingsEndpoints(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLStandings> GetCurrentAsync(string standingsType = StandingsTypes.RegularSeason)
        {
            var response = await _requester.GetRequestAsync<NHLStandings>($"{Urls.StandingsUrl}?standingsType={standingsType}");
            return response;
        }

        public async Task<NHLStandings> GetBySeasonAsync(string season, string standingsType = StandingsTypes.RegularSeason)
        {
            if (string.IsNullOrEmpty(season))
            {
                return null;
            }

            var response = await _requester.GetRequestAsync<NHLStandings>($"{Urls.StandingsUrl}?season={season}&standingsType={standingsType}");
            return response;
        }

        #endregion

        #region Sync

        public NHLStandings GetCurrent(string standingsType = StandingsTypes.RegularSeason)
        {
            var response = _requester.GetRequest<NHLStandings>($"{Urls.StandingsUrl}?standingsType={standingsType}");
            return response;
        }

        public NHLStandings GetBySeason(string season, string standingsType = StandingsTypes.RegularSeason)
        {
            if (string.IsNullOrEmpty(season))
            {
                return null;
            }

            var response = _requester.GetRequest<NHLStandings>($"{Urls.StandingsUrl}?season={season}&standingsType={standingsType}");
            return response;
        }

        #endregion


    }
}
