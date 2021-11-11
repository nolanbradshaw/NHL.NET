using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHL.NET.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NHL.NET.Json
{
    internal static class TeamStatsReader
    {
        public static List<NHLTeamNumericStatSplit> GetTeamNumericStatSplits(this JObject jsonObject)
        {
            try
            {
                // The object we want from the array contains a statsType display name of statsSingleSeason.
                var singleSeasonStatSplits = jsonObject["stats"].Where(x => x["type"].Value<string>("displayName") == "statsSingleSeason");
                // The stats object is an array and we only care about the first object (Never seen more than one object in that array anyway).
                var statArray = JArray.Parse(JsonConvert.SerializeObject(singleSeasonStatSplits))[0]["splits"];
                return JsonConvert.DeserializeObject<List<NHLTeamNumericStatSplit>>(JsonConvert.SerializeObject(statArray));
            }
            catch (Exception ex)
            {
                // TODO: Some log output so the consumer understands why the result is null.
                return null;
            }
        }

        public static List<NHLTeamRankStatSplit> GetTeamStatRankSplits(this JObject jsonObject)
        {
            try
            {
                // The object we want from the array contains a statsType display name of regularSeasonStatRankings.
                var statRankingSplits = jsonObject["stats"].Where(x => x["type"].Value<string>("displayName") == "regularSeasonStatRankings");
                // The stats object is an array and we only care about the first object (Never seen more than one object in that array anyway).
                var statArray = JArray.Parse(JsonConvert.SerializeObject(statRankingSplits))[0]["splits"];
                return JsonConvert.DeserializeObject<List<NHLTeamRankStatSplit>>(JsonConvert.SerializeObject(statArray));
            }
            catch (Exception ex)
            {
                // TODO: Some log output so the consumer understands why the result is null.
                return null;
            }
        }

        public static NHLTeamStats ParseTeamStats(this JObject jsonObject)
        {
            // Get the numeric and rank stats objects from the single stats array.
            var numeric = jsonObject.GetTeamNumericStatSplits().FirstOrDefault()?.Stat;
            var rank = jsonObject.GetTeamStatRankSplits().FirstOrDefault()?.Stat;

            if (numeric is null || rank is null)
            {
                return null;
            }

            // Flatten the array objects into a single object.
            // This just ends up feeling much more logical to consumers.
            return new NHLTeamStats()
            {
                GamesPlayed = numeric.GamesPlayed,
                Wins = numeric.Wins,
                WinsRank = rank.Wins,
                Losses = numeric.Losses,
                LossesRank = rank.Losses,
                OvertimeLosses = numeric.OvertimeLosses,
                OvertimeLossesRank = rank.OvertimeLosses,
                Points = numeric.Points,
                PointsRank = rank.Points,
                PointsPercentage = numeric.PointsPercentage,
                PointsPercentageRank = rank.PointsPercentage,

                GoalsPerGame = numeric.GoalsPerGame,
                GoalsPerGameRank = rank.GoalsPerGame,
                GoalsAgainstPerGame = numeric.GoalsAgainstPerGame,
                GoalsAgainstPerGameRank = rank.GoalsAgainstPerGame,

                PowerPlayPercentage = numeric.PowerPlayPercentage,
                PowerPlayRank = rank.PowerPlayPercentage,
                PowerPlayGoals = numeric.PowerPlayGoals,
                PowerPlayGoalsRank = rank.PowerPlayGoals,
                PowerPlayGoalsAgainst = numeric.PowerPlayGoalsAgainst,
                PowerPlayGoalsAgainstRank = rank.PowerPlayGoalsAgainst,
                PowerPlayOpportunities = numeric.PowerPlayOpportunities,

                PowerPlayOpportunitiesRank = rank.PowerPlayOpportunities,
                PenaltyKillPercentage = numeric.PenaltyKillPercentage,
                PenaltyKillRank = rank.PenaltyKillPercentage,

                ShotsPerGame = numeric.ShotsPerGame,
                ShotsPerGameRank = rank.ShotsPerGame,
                ShotsAllowed = numeric.ShotsAllowed,
                ShotsAllowedRank = rank.ShotsAllowed,

                ScoreFirstWinPercentage = numeric.ScoreFirstWinPercentage,
                ScoreFirstWinPercentageRank = rank.ScoreFirstWinPercentage,
                OppScoreFirstWinPercentage = numeric.OppScoreFirstWinPercentage,
                OppScoreFirstWinPercentageRank = rank.OppScoreFirstWinPercentage,

                LeadAfterFirstWinPercentage = numeric.LeadAfterFirstWinPercentage,
                LeadAfterFirstWinPercentageRank = rank.LeadAfterFirstWinPercentage,
                LeadAfterSecondWinPercentage = numeric.LeadAfterSecondWinPercentage,
                LeadAfterSecondWinPercentageRank = rank.LeadAfterSecondWinPercentage,

                OutshootWinPercentage = numeric.OutshootWinPercentage,
                OutshootWinPercentageRank = rank.OutshootWinPercentage,
                OutshotWinPercentage = numeric.OutshotWinPercentage,
                OutshotWinPercentageRank = rank.OutshotWinPercentage,

                FaceoffsTaken = numeric.FaceoffsTaken,
                FaceoffsTakenRank = rank.FaceoffsTaken,
                FaceoffsWon = numeric.FaceoffsWon,
                FaceoffsWonRank = rank.FaceoffsWon,
                FaceoffsLost = numeric.FaceoffsLost,
                FaceoffsLostRank = rank.FaceoffsLost,
                FaceoffWinPercentage = numeric.FaceoffWinPercentage,
                FaceoffWinPercentageRank = rank.FaceoffWinPercentage,

                ShootingPercentage = numeric.ShootingPercentage,
                ShootingPercentageRank = rank.ShootingPercentage,
                SavePercentage = numeric.SavePercentage,
                SavePercentageRank = rank.SavePercentage
            };
        }
    }
}
