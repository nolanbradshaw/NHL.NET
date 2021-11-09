using NHL.NET.Models.Team;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Team
{
    public interface ITeamEndpoint
    {
        Task<NHLTeamList> GetAllAsync();
        Task<NHLTeam> GetByIdAsync(int teamId);
        Task<NHLTeamList> GetMultipleAsync(List<int> teamIds);
        NHLTeamList GetAll();
        NHLTeam GetById(int teamId);
        NHLTeamList GetMultiple(List<int> teamIds);
    }
}
