using Newtonsoft.Json;
using System.Collections.Generic;

namespace NHL.NET.Models.Game
{
    public class NHLGameBoxscore
    {
        public NHLGameBoxscore()
        {
            Teams = new Dictionary<string, NHLGameTeam>();
        }

        [JsonProperty]
        private Dictionary<string, NHLGameTeam> Teams { get; set; }

        public NHLGameTeam Home
        {
            get
            {
                if (Teams.ContainsKey("home"))
                {
                    return Teams["home"];
                }

                return null;
            }
        }

        public NHLGameTeam Away
        {
            get
            {
                if (Teams.ContainsKey("home"))
                {
                    return Teams["away"];
                }

                return null;
            }
        }
    }
}
