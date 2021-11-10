using NHL.NET.Models.Conference;
using NHL.NET.Models.Division;
using NHL.NET.Models.Franchise;
using NHL.NET.Models.League;

namespace NHL.NET.Models.Team
{
    public class NHLTeam
    {
        public int Id { get; set; }

        public int FranchiseId { get; set; }

        public string Name { get; set; }

        public NHLVenue Venue { get; set; }

        public NHLSimpleFranchise Franchise { get; set; }

        public NHLSimpleConference Conference { get; set; }

        public NHLSimpleDivision Division { get; set; }

        public string Abbreviation { get; set; }

        public string TeamName { get; set; }

        public string LocationName { get; set; }

        public string FirstYearOfPlay { get; set; }

        public string ShortName { get; set; }

        public string OfficialSite { get; set; }

        public bool Active { get; set; }
    }
}
