﻿using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Franchise
{
    public class FranchiseEndpoint : IFranchiseEndpoint
    {
        private readonly IRequester _requester;
        public FranchiseEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        #region Async
        public async Task<NHLFranchiseList> GetAllAsync()
        {
            var franchiseList = await _requester.GetRequestAsync<NHLFranchiseList>("https://statsapi.web.nhl.com/api/v1/franchises");
            return franchiseList;
        }

        public async Task<NHLFranchise> GetByIdAsync(int franchiseId)
        {
            // API always returns a list
            var franchiseList = await _requester.GetRequestAsync<NHLFranchiseList>($"https://statsapi.web.nhl.com/api/v1/franchises/{franchiseId}");

            if (franchiseList != null && franchiseList.Franchises?.Count == 1)
            {
                return franchiseList.Franchises.First();
            }

            return null;
        }

        public async Task<NHLFranchiseList> GetMultipleByIdAsync(IEnumerable<int> franchiseIds)
        {
            var queryString = $"franchiseId={string.Join(",", franchiseIds)}";
            var franchiseList = await _requester.GetRequestAsync<NHLFranchiseList>($"https://statsapi.web.nhl.com/api/v1/franchises?{queryString}");

            return franchiseList;
        }

        #endregion

        #region Sync

        public NHLFranchiseList GetAll()
        {
            var franchiseList = _requester.GetRequest<NHLFranchiseList>("https://statsapi.web.nhl.com/api/v1/franchises");
            return franchiseList;
        }

        public NHLFranchise GetById(int franchiseId)
        {
            // API always returns a list
            var franchiseList = _requester.GetRequest<NHLFranchiseList>($"https://statsapi.web.nhl.com/api/v1/franchises/{franchiseId}");

            if (franchiseList != null && franchiseList.Franchises?.Count == 1)
            {
                return franchiseList.Franchises.First();
            }

            return null;
        }

        public NHLFranchiseList GetMultipleById(IEnumerable<int> franchiseIds)
        {
            var queryString = $"franchiseId={string.Join(",", franchiseIds)}";
            var franchiseList = _requester.GetRequest<NHLFranchiseList>($"https://statsapi.web.nhl.com/api/v1/franchises?{queryString}");

            return franchiseList;
        }

        #endregion
    }
}