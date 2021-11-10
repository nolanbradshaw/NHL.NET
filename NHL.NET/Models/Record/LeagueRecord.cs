using Newtonsoft.Json;

namespace NHL.NET.Models.Record
{
    public class LeagueRecord
    {
        public int Wins { get; set; }

        public int Losses { get; set; }

        [JsonProperty(PropertyName = "ot")]
        public int OvertimeLosses { get; set; }

        public string Type { get; set; }
    }
}
