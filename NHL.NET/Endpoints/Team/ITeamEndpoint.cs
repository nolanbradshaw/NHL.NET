using NHL.NET.Models.Team;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Team
{
    public interface ITeamEndpoint
    {
        Task<NHLTeamStats> GetTeamStatsAsync(int teamId, string season = "");
        Task<NHLTeamList> GetAllAsync();
        Task<NHLTeam> GetByIdAsync(int teamId);
        Task<NHLTeamList> GetMultipleAsync(List<int> teamIds);
        NHLTeamStats GetTeamStats(int teamId, string season = "");
        NHLTeamList GetAll();
        NHLTeam GetById(int teamId);
        NHLTeamList GetMultiple(List<int> teamIds);
    }
}
