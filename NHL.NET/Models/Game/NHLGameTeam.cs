using Newtonsoft.Json;
using NHL.NET.Models.Team;
using System.Collections.Generic;

namespace NHL.NET.Models.Game
{
    public class NHLGameTeam
    {
        public NHLGameTeam()
        {
            TeamStats = new Dictionary<string, NHLGameTeamStats>();
        }

        public NHLSimpleTeam Team { get; set; }

        [JsonProperty]
        private Dictionary<string, NHLGameTeamStats> TeamStats { get; set; }

        [JsonIgnore]
        public NHLGameTeamStats Stats
        {
            get
            {
                const string propertyName = "teamSkaterStats";
                if (TeamStats.ContainsKey(propertyName))
                {
                    return TeamStats[propertyName];
                }

                return null;
            }
        }
    }
}
