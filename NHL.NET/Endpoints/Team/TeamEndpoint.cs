using Newtonsoft.Json.Linq;
using NHL.NET.Constants;
using NHL.NET.Http.Interfaces;
using NHL.NET.Json;
using NHL.NET.Models.Team;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Team
{
    public class TeamEndpoint : ITeamEndpoint
    {
        private readonly IRequester _requester;
        public TeamEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLTeamList> GetAllAsync()
        {
            var teamList = await _requester.GetRequestAsync<NHLTeamList>(Urls.TeamUrl);
            return teamList;
        }

        public async Task<NHLTeam> GetByIdAsync(int teamId)
        {
            var teamList = await _requester.GetRequestAsync<NHLTeamList>($"{Urls.TeamUrl}/{teamId}");
            if (teamList != null && teamList.Teams?.Count == 1)
            {
                return teamList.Teams[0];
            }

            return null;
        }

        public async Task<NHLTeamList> GetMultipleAsync(List<int> teamIds)
        {
            var queryString = $"teamId={string.Join(",", teamIds)}";
            var teamList = await _requester.GetRequestAsync<NHLTeamList>($"{Urls.TeamUrl}?{queryString}");

            return teamList;
        }

        public async Task<NHLTeamStats> GetStatsAsync(int teamId, string season = "")
        {
            var queryString = "";
            if (!string.IsNullOrEmpty(season))
            {
                // Only add query string if a season was given.
                queryString = $"?season={season}";
            }

            var jsonString = await _requester.GetRequestAsync($"{Urls.TeamUrl}/{teamId}/stats{queryString}");
            if (string.IsNullOrEmpty(jsonString))
            {
                return null;
            }

            // The API response contains 2 different objects in a single array.
            // This makes parsing more complicated than simply using JsonConvert.
            var parsed = JObject.Parse(jsonString);
            return parsed.ParseTeamStats();
        }

        #endregion

        #region Sync

        public NHLTeamList GetAll()
        {
            var teamList = _requester.GetRequest<NHLTeamList>(Urls.TeamUrl);
            return teamList;
        }

        public NHLTeam GetById(int teamId)
        {
            var teamList = _requester.GetRequest<NHLTeamList>($"{Urls.TeamUrl}/{teamId}");
            if (teamList != null && teamList.Teams?.Count == 1)
            {
                return teamList.Teams[0];
            }

            return null;
        }

        public NHLTeamList GetMultiple(List<int> teamIds)
        {
            var queryString = $"teamId={string.Join(",", teamIds)}";
            var teamList = _requester.GetRequest<NHLTeamList>($"{Urls.TeamUrl}?{queryString}");

            return teamList;
        }

        public NHLTeamStats GetStats(int teamId, string season = "")
        {
            var queryString = "";
            if (!string.IsNullOrEmpty(season))
            {
                // Only add query string if a season was given.
                queryString = $"?season={season}";
            }

            var jsonString = _requester.GetRequest($"{Urls.TeamUrl}/{teamId}/stats{queryString}");
            if (string.IsNullOrEmpty(jsonString))
            {
                return null;
            }

            // The API response contains 2 different objects in a single array.
            // This makes parsing more complicated than simply using JsonConvert.
            var parsed = JObject.Parse(jsonString);
            return parsed.ParseTeamStats();
        }

        #endregion

    }
}
