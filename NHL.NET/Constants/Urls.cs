using System;
using System.Collections.Generic;
using System.Text;

namespace NHL.NET.Constants
{
    public static class Urls
    {
        public const string StatsApiUrl = "https://statsapi.web.nhl.com/api/v1/";

        public static readonly string FranchiseUrl = $"{StatsApiUrl}franchises";

        public static readonly string TeamUrl = $"{StatsApiUrl}teams";

        public static readonly string DivisionUrl = $"{StatsApiUrl}divisions";
    }
}
