using Newtonsoft.Json;

namespace NHL.NET.Models.Franchise
{
    public class NHLFranchise
    {
        [JsonProperty(PropertyName = "FranchiseId")]
        public int Id { get; set; }

        public string FirstSeasonId { get; set; }

        public string LastSeasonId { get; set; }

        public int MostRecentTeamId { get; set; }

        public string TeamName { get; set; }

        public string LocationName { get; set; }
    }
}
