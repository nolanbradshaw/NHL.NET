using NHL.NET.Models.Team;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Team
{
    public interface ITeamEndpoint
    {
        Task<NHLTeamStats> GetTeamStatsAsync(int teamId);
        Task<NHLTeamList> GetAllAsync();
        Task<NHLTeam> GetByIdAsync(int teamId);
        Task<NHLTeamList> GetMultipleAsync(List<int> teamIds);
        NHLTeamStats GetTeamStats(int teamId);
        NHLTeamList GetAll();
        NHLTeam GetById(int teamId);
        NHLTeamList GetMultiple(List<int> teamIds);
    }
}
