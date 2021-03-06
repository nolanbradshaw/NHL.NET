using NHL.NET.Constants;
using NHL.NET.Exceptions;
using NHL.NET.Http.Interfaces;
using NHL.NET.Models.Conference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Conference
{
    public class ConferenceEndpoints : IConferenceEndpoints
    {
        private readonly IRequester _requester;
        public ConferenceEndpoints(IRequester requester)
        {
            _requester = requester;
        }

        #region Async

        public async Task<NHLConferenceList> GetAllAsync()
        {
            var response = await _requester.GetRequestAsync<NHLConferenceList>(Urls.ConferenceUrl);
            return response;
        }

        public async Task<NHLConference> GetByIdAsync(int conferenceId)
        {
            var response = await _requester.GetRequestAsync<NHLConferenceList>($"{Urls.ConferenceUrl}/{conferenceId}");
            if (response != null && response.Conferences?.Count > 0)
            {
                return response.Conferences.First();
            }

            throw new NHLClientException($"No Conference with the id {conferenceId} could be found.");
        }

        public async Task<NHLConferenceList> GetMultipleAsync(List<int> conferenceIds)
        {
            var queryString = $"conferenceId={string.Join(",", conferenceIds)}";
            var response = await _requester.GetRequestAsync<NHLConferenceList>($"{Urls.ConferenceUrl}?{queryString}");
            return response;
        }

        #endregion

        #region Sync

        public NHLConferenceList GetAll()
        {
            var response = _requester.GetRequest<NHLConferenceList>(Urls.ConferenceUrl);
            return response;
        }

        public NHLConference GetById(int conferenceId)
        {
            var response = _requester.GetRequest<NHLConferenceList>($"{Urls.ConferenceUrl}/{conferenceId}");
            if (response != null && response.Conferences?.Count > 0)
            {
                return response.Conferences.First();
            }

            throw new NHLClientException($"No Conference with the id {conferenceId} could be found.");
        }

        public NHLConferenceList GetMultiple(List<int> conferenceIds)
        {
            var queryString = $"conferenceId={string.Join(",", conferenceIds)}";
            var response = _requester.GetRequest<NHLConferenceList>($"{Urls.ConferenceUrl}?{queryString}");
            return response;
        }

        #endregion
    }
}
