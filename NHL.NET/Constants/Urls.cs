namespace NHL.NET.Constants
{
    public static class Urls
    {
        public const string StatsApiUrl = "https://statsapi.web.nhl.com/api/v1/";

        public static readonly string FranchiseUrl = $"{StatsApiUrl}franchises";

        public static readonly string GameUrl = $"{StatsApiUrl}game";

        public static readonly string TeamUrl = $"{StatsApiUrl}teams";

        public static readonly string DivisionUrl = $"{StatsApiUrl}divisions";

        public static readonly string StandingsUrl = $"{StatsApiUrl}standings";

        public static readonly string ConferenceUrl = $"{StatsApiUrl}conferences";

        public static readonly string PlayerUrl = $"{StatsApiUrl}people";
    }
}
