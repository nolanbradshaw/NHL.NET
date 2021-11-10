using NHL.NET.Constants;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Division;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Division
{
    public class DivisionEndpoint: IDivisionEndpoint 
    {
        private readonly IRequester _requester;
        public DivisionEndpoint(IRequester requester)
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
            if (response != null && response.Divisions?.Count == 1)
            {
                return response.Divisions[0];
            }

            return null;
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
            if (response != null && response.Divisions?.Count == 1)
            {
                return response.Divisions[0];
            }

            return null;
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
