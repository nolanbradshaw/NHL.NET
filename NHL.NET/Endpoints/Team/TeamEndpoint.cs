﻿using NHL.NET.Constants;
using NHL.NET.Http.Interfaces;
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

        #endregion

    }
}