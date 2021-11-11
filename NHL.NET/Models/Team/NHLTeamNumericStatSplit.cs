using Newtonsoft.Json;
using System;

namespace NHL.NET.Models.Team
{
    internal class TeamNumericStat
    {
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }

        public int Losses { get; set; }

        [JsonProperty(PropertyName = "ot")]
        public int OvertimeLosses { get; set; }

        [JsonProperty(PropertyName = "pts")]
        public int Points { get; set; }

        [JsonProperty(PropertyName = "ptPctg")]
        public float PointsPercentage { get; set; }

        public float GoalsPerGame { get; set; }

        public float GoalsAgainstPerGame { get; set; }

        public float PowerPlayPercentage { get; set; }

        [JsonProperty(PropertyName = "powerPlayGoals")]
        private float PowerPlayGoalsValue { get; set; }

        [JsonIgnore]
        public int PowerPlayGoals
        {
            get
            {
                return Convert.ToInt32(this.PowerPlayGoalsValue);
            }
        }

        [JsonProperty(PropertyName = "powerPlayGoalsAgainst")]
        private float PowerPlayGoalsAgainstValue { get; set; }

        [JsonIgnore]
        public int PowerPlayGoalsAgainst
        {
            get
            {
                return Convert.ToInt32(this.PowerPlayGoalsAgainstValue);
            }
        }


        [JsonProperty(PropertyName = "powerPlayOpportunities")]
        private float PowerPlayOpportunitiesValue { get; set; }


        [JsonIgnore]
        public int PowerPlayOpportunities
        {
            get
            {
                return Convert.ToInt32(this.PowerPlayOpportunitiesValue);
            }
        }

        public float PenaltyKillPercentage { get; set; }

        public float ShotsPerGame { get; set; }

        public float ShotsAllowed { get; set; }

        [JsonProperty(PropertyName = "winScoreFirst")]
        public float ScoreFirstWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winOppScoreFirst")]
        public float OppScoreFirstWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winLeadFirstPer")]
        public float LeadAfterFirstWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winLeadSecondPer")]
        public float LeadAfterSecondWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winOutshootOpp")]
        public float OutshootWinPercentage { get; set; }

        [JsonProperty(PropertyName = "winOutshotByOpp")]
        public float OutshotWinPercentage { get; set; }

        [JsonProperty(PropertyName = "faceOffsTaken")]
        private float FaceoffsTakenValue { get; set; }

        [JsonIgnore]
        public int FaceoffsTaken
        {
            get
            {
                return Convert.ToInt32(this.FaceoffsTakenValue);
            }
        }

        [JsonProperty(PropertyName = "faceOffsWon")]
        private float FaceoffsWonValue { get; set; }

        [JsonIgnore]
        public int FaceoffsWon
        {
            get
            {
                return Convert.ToInt32(this.FaceoffsWonValue);
            }
        }

        [JsonProperty(PropertyName = "faceOffsLost")]
        private float FaceoffsLostValue { get; set; }

        [JsonIgnore]
        public int FaceoffsLost
        {
            get
            {
                return Convert.ToInt32(this.FaceoffsLostValue);
            }
        }

        [JsonProperty(PropertyName = "faceOffWinPercentage")]
        public float FaceoffWinPercentage { get; set; }

        [JsonProperty(PropertyName = "shootingPctg")]
        public float ShootingPercentage { get; set; }

        [JsonProperty(PropertyName = "savePctg")]
        public float SavePercentage { get; set; }
    }
    internal class NHLTeamNumericStatSplit
    {
        public TeamNumericStat Stat { get; set; }
    }
}
