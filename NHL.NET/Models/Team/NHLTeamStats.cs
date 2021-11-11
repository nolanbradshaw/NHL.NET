namespace NHL.NET.Models.Team
{
    public class NHLTeamStats
    {
        public int GamesPlayed { get; set; }

        public int Wins { get; set; }

        public string WinsRank { get; set; }

        public int Losses { get; set; }

        public string LossesRank { get; set; }

        public int OvertimeLosses { get; set; }

        public string OvertimeLossesRank { get; set; }

        public int Points { get; set; }

        public string PointsRank { get; set; }

        public float PointsPercentage { get; set; }

        public string PointsPercentageRank { get; set; }

        public float GoalsPerGame { get; set; }

        public string GoalsPerGameRank { get; set; }

        public float GoalsAgainstPerGame { get; set; }

        public string GoalsAgainstPerGameRank { get; set; }

        public float PowerPlayPercentage { get; set; }

        public string PowerPlayRank { get; set; }

        public int PowerPlayGoals { get; set; }

        public string PowerPlayGoalsRank { get; set; }

        public int PowerPlayGoalsAgainst { get; set; }

        public string PowerPlayGoalsAgainstRank { get; set; }

        public int PowerPlayOpportunities { get; set; }

        public string PowerPlayOpportunitiesRank { get; set; }

        public float PenaltyKillPercentage { get; set; }

        public string PenaltyKillRank { get; set; }

        public float ShotsPerGame { get; set; }

        public string ShotsPerGameRank { get; set; }

        public float ShotsAllowed { get; set; }

        public string ShotsAllowedRank { get; set; }

        public float ScoreFirstWinPercentage { get; set; }

        public string ScoreFirstWinPercentageRank { get; set; }

        public float OppScoreFirstWinPercentage { get; set; }

        public string OppScoreFirstWinPercentageRank { get; set; }

        public float LeadAfterFirstWinPercentage { get; set; }

        public string LeadAfterFirstWinPercentageRank { get; set; }

        public float LeadAfterSecondWinPercentage { get; set; }

        public string LeadAfterSecondWinPercentageRank { get; set; }

        public float OutshootWinPercentage { get; set; }

        public string OutshootWinPercentageRank { get; set; }

        public float OutshotWinPercentage { get; set; }

        public string OutshotWinPercentageRank { get; set; }

        public int FaceoffsTaken { get; set; }

        public string FaceoffsTakenRank { get; set; }

        public int FaceoffsWon { get; set; }

        public string FaceoffsWonRank { get; set; }

        public int FaceoffsLost { get; set; }

        public string FaceoffsLostRank { get; set; }

        public float FaceoffWinPercentage { get; set; }

        public string FaceoffWinPercentageRank { get; set; }

        public float ShootingPercentage { get; set; }

        public string ShootingPercentageRank { get; set; }

        public float SavePercentage { get; set; }

        public string SavePercentageRank { get; set; }
    }
}
