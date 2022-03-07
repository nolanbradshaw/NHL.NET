using NHL.NET.Constants;
using NHL.NET.Exceptions;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Division;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Division
{
    public class DivisionEndpoints: IDivisionEndpoints 
    {
        private readonly IRequester _requester;
        public DivisionEndpoints(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLDivisionList> GetAllAsync()
        {
            var response = await _requester.GetRequestAsync<NHLDivisionList>(Urls.DivisionUrl);
            return response;
        }

        public async Task<NHLDivision> GetByIdAsync(int divisionId)
        {
            // Response is always in the form of a list
            var response = await _requester.GetRequestAsync<NHLDivisionList>($"{Urls.DivisionUrl}/{divisionId}");
            if (response != null && response.Divisions?.Count > 0)
            {
                return response.Divisions.First();
            }

            throw new NHLClientException($"No division with the id {divisionId} could be found.");
        }

        public async Task<NHLDivisionList> GetMultipleAsync(List<int> divisionIds)
        {
            var queryString = $"divisionId={string.Join(",", divisionIds)}";
            var response = await _requester.GetRequestAsync<NHLDivisionList>($"{Urls.DivisionUrl}?{queryString}");

            return response;
        }

        #endregion

        #region Sync

        public NHLDivisionList GetAll()
        {
            var response = _requester.GetRequest<NHLDivisionList>(Urls.DivisionUrl);
            return response;
        }

        public NHLDivision GetById(int divisionId)
        {
            // Response is always in the form of a list
            var response = _requester.GetRequest<NHLDivisionList>($"{Urls.DivisionUrl}/{divisionId}");
            if (response != null && response.Divisions?.Count > 0)
            {
                return response.Divisions.First();
            }

            throw new NHLClientException($"No division with the id {divisionId} could be found.");
        }

        public NHLDivisionList GetMultiple(List<int> divisionIds)
        {
            var queryString = $"divisionId={string.Join(",", divisionIds)}";
            var response = _requester.GetRequest<NHLDivisionList>($"{Urls.DivisionUrl}?{queryString}");

            return response;
        }

        #endregion
    }
}
