using NHL.NET.Models.Stats;
using System.Collections.Generic;

namespace NHL.NET.Models.Player
{
    public class NHLPlayerStats
    {
        public StatsType Type { get; set; }

        public List<NHLPlayerStatsSplit> Splits { get; set; }
    }
}
