using Newtonsoft.Json;
using NHL.NET.Models.Streak;
using NHL.NET.Models.Team;
using System;

namespace NHL.NET.Models.Record
{
    public class TeamRecord
    {
        public NHLSimpleTeam Team { get; set; }

        public LeagueRecord LeagueRecord { get; set; }

        public int RegulationWins { get; set; }

        public int GoalsAgainst { get; set; }

        public int GoalsScored { get; set; }

        public int Points { get; set; }

        public int DivisionRank { get; set; }

        [JsonProperty(PropertyName = "divisionL10Rank")]
        public int DivisionLastTenRank { get; set; }

        public int DivisionRoadRank { get; set; }

        public int DivisionHomeRank { get; set; }

        public int ConferenceRank { get; set; }

        [JsonProperty(PropertyName = "conferenceL10Rank")]
        public int ConferenceLastTenRank { get; set; }

        public int ConferenceRoadRank { get; set; }

        public int ConferenceHomeRank { get; set; }

        public int LeagueRank { get; set; }

        [JsonProperty(PropertyName = "leagueL10Rank")]
        public int LeagueLastTenRank { get; set; }

        public int LeagueRoadRank { get; set; }

        public int LeagueHomeRank { get; set; }

        public int WildCardRank { get; set; }

        public int Row { get; set; }

        public int GamePlayed { get; set; }

        public SimpleStreak Streak { get; set; }

        public float PointsPercentage { get; set; }

        [JsonProperty(PropertyName = "ppDivisionRank")]
        public int PowerplayDivisionRank { get; set; }

        [JsonProperty(PropertyName = "ppConferenceRank")]
        public int PowerplayConferenceRank { get; set; }

        [JsonProperty(PropertyName = "ppLeagueRank")]
        public int PowerplayLeagueRank { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
