using Newtonsoft.Json;

namespace NHL.NET.Models.Game
{
    public class NHLGameTeamStats
    {
        public int Goals { get; set; }

        [JsonProperty(PropertyName = "pim")]
        public int PenaltiesInMinutes { get; set; }

        public int Shots { get; set; }

        public decimal PowerPlayPercentage { get; set; }
        public decimal PowerPlayGoals { get; set; }

        public decimal PowerPlayOpportunities { get; set; }

        public decimal FaceOffWinPercentage { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        public int BlockedShots { get; set; }

        public int Takeaways { get; set; }

        public int Giveaways { get; set; }

        public int Hits { get; set; }
    }
}
