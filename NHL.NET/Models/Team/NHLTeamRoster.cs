using Newtonsoft.Json;
using NHL.NET.Models.Player;
using System.Collections.Generic;

namespace NHL.NET.Models.Team
{
    public class NHLTeamRoster
    {
        [JsonProperty(PropertyName = "roster")]
        public List<NHLRosterPlayer> Players { get; set; }
    }
}
