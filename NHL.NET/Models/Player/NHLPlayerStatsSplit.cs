using Newtonsoft.Json;

namespace NHL.NET.Models.Player
{
    public class NHLPlayerStatsSplit
    {
        public string TimeOnIce { get; set; }

        public int Assists { get; set; }

        public int Goals { get; set; }

        public int PenaltyMinutes { get; set; }

        public int Shots { get; set; }

        public int Games { get; set; }

        public int Hits { get; set; }

        public int PowerPlayGoals { get; set; }

        public int PowerPlayPoints { get; set; }

        public string PowerPlayTimeOnIce { get; set; }

        public string EvenTimeOnIce { get; set; }

        [JsonProperty(PropertyName = "faceOffPct")]
        public float FaceoffPercentage { get; set; }

        [JsonProperty(PropertyName = "shotPct")]
        public float ShootingPercentage { get; set; }

        public int GameWinningGoals { get; set; }

        public int OvertimeGoals { get; set; }

        public int ShortHandedGoals { get; set; }

        public int ShortHandedPoints { get; set; }

        public string ShotHandedTimeOnIce { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        public int BlockedShots { get; set; }

        public int PlusMinus { get; set; }

        public int Points { get; set; }

        public int Shifts { get; set; }

        public string TimeOnIcePerGame { get; set; }

        public string EvenTimeOnIcePerGame { get; set; }

        public string ShortHandedTimeOnIcePerGame { get; set; }

        public string PowerPlayTimeOnIcePerGame { get; set; }
    }
}
