using NHL.NET.Models.Conference;
using NHL.NET.Models.Division;
using NHL.NET.Models.League;
using NHL.NET.Models.Record;
using System.Collections.Generic;

namespace NHL.NET.Models.Standings
{
    public class NHLStandingsRecord
    {
        public string StandingsType { get; set; }

        public string Season { get; set; }

        public SimpleLeague League { get; set; }

        public NHLSimpleDivision Division { get; set; }

        public NHLSimpleConference Conference { get; set; }

        public List<TeamRecord> TeamRecords { get; set; }
    }
}
