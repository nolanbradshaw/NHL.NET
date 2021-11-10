using NHL.NET.Models.Conference;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Conference
{
    public interface IConferenceEndpoints
    {
        Task<NHLConferenceList> GetAllAsync();
        Task<NHLConference> GetByIdAsync(int conferenceId);
        Task<NHLConferenceList> GetMultipleAsync(List<int> conferenceIds);
        NHLConferenceList GetAll();
        NHLConference GetById(int conferenceId);
        NHLConferenceList GetMultiple(List<int> conferenceIds);
    }
}
