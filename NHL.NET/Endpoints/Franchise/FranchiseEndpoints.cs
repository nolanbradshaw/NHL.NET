using NHL.NET.Constants;
using NHL.NET.Exceptions;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Franchise;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Franchise
{
    public class FranchiseEndpoints : IFranchiseEndpoints
    {
        private readonly IRequester _requester;
        public FranchiseEndpoints(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLFranchiseList> GetAllAsync()
        {
            var franchiseList = await _requester.GetRequestAsync<NHLFranchiseList>(Urls.FranchiseUrl);
            return franchiseList;
        }

        public async Task<NHLFranchise> GetByIdAsync(int franchiseId)
        {
            // API always returns a list
            var franchiseList = await _requester.GetRequestAsync<NHLFranchiseList>($"{Urls.FranchiseUrl}/{franchiseId}");

            if (franchiseList != null && franchiseList.Franchises?.Count > 0)
            {
                return franchiseList.Franchises.First();
            }

            throw new NHLClientException($"No franchise with the id {franchiseId} exists.");
        }

        public async Task<NHLFranchiseList> GetMultipleByIdAsync(IEnumerable<int> franchiseIds)
        {
            var queryString = $"franchiseId={string.Join(",", franchiseIds)}";
            var franchiseList = await _requester.GetRequestAsync<NHLFranchiseList>($"{Urls.FranchiseUrl}?{queryString}");

            return franchiseList;
        }

        #endregion

        #region Sync

        public NHLFranchiseList GetAll()
        {
            var franchiseList = _requester.GetRequest<NHLFranchiseList>(Urls.FranchiseUrl);
            return franchiseList;
        }

        public NHLFranchise GetById(int franchiseId)
        {
            // API always returns a list
            var franchiseList = _requester.GetRequest<NHLFranchiseList>($"{Urls.FranchiseUrl}/{franchiseId}");

            if (franchiseList != null && franchiseList.Franchises?.Count > 0)
            {
                return franchiseList.Franchises.First();
            }

            throw new NHLClientException($"No franchise with the id {franchiseId} exists.");
        }

        public NHLFranchiseList GetMultipleById(IEnumerable<int> franchiseIds)
        {
            var queryString = $"franchiseId={string.Join(",", franchiseIds)}";
            var franchiseList = _requester.GetRequest<NHLFranchiseList>($"{Urls.FranchiseUrl}?{queryString}");

            return franchiseList;
        }

        #endregion
    }
}
