using Newtonsoft.Json;

namespace NHL.NET.Models.Team
{
    internal class TeamRankStat
    {

        public int GamesPlayed { get; set; }
        public string Wins { get; set; }

        public string Losses { get; set; }

        [JsonProperty(PropertyName = "ot")]
        public string OvertimeLosses { get; set; }

        [JsonProperty(PropertyName = "pts")]
        public string Points { get; set; }

        [JsonProperty(PropertyName = "ptPctg")]
        public string PointsPercentage { get; set; }

        [JsonProperty(PropertyName = "goalsPerGame")]
        public string GoalsPerGame { get; set; }

        public string GoalsAgainstPerGame { get; set; }

        public string PowerPlayPercentage { get; set; }

        public string PowerPlayGoals { get; set; }

        public string PowerPlayGoalsAgainst { get; set; }

        public string PowerPlayOpportunities { get; set; }

        public string PenaltyKillOpportunities { get; set; }

        public string PenaltyKillPercentage { get; set; }

        public string ShotsPerGame { get; set; }

        public string ShotsAllowed { get; set; }

        [JsonProperty(PropertyName = "winScoreFirst")]
        public string ScoreFirstWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winOppScoreFirst")]
        public string OppScoreFirstWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winLeadFirstPer")]
        public string LeadAfterFirstWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winLeadSecondPer")]
        public string LeadAfterSecondWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winOutshootOpp")]
        public string OutshootWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winOutshotByOpp")]
        public string OutshotWinPercentage { get; set; }

        [JsonProperty(PropertyName = "faceOffsTaken")]
        public string FaceoffsTaken { get; set; }

        [JsonProperty(PropertyName = "faceOffsWon")]
        public string FaceoffsWon { get; set; }

        [JsonProperty(PropertyName = "faceOffsLost")]
        public string FaceoffsLost { get; set; }

        [JsonProperty(PropertyName = "faceOffWinPercentage")]
        public string FaceoffWinPercentage { get; set; }

        [JsonProperty(PropertyName = "savePctRank")]
        public string SavePercentage { get; set; }

        [JsonProperty(PropertyName = "shootingPctRank")]
        public string ShootingPercentage { get; set; }
    }
    internal class NHLTeamRankStatSplit
    {
        public TeamRankStat Stat { get; set; }
    }
}
