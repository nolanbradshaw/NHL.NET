namespace NHL.NET.Models.Streak
{
    public class SimpleStreak
    {
        /// <summary>
        /// Wins/Losses
        /// </summary>
        public string StreakType { get; set; }

        /// <summary>
        /// Length of the streak
        /// </summary>
        public int StreakNumber { get; set; }

        /// <summary>
        /// Type and number formed into a code.
        /// Ex. Type = Wins, number = 8. Code = W8.
        /// </summary>
        public string StreakCode { get; set; }
    }
}
