using NHL.NET.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class StandingsTests
    {
        private const string Season = "20132014";
        private readonly NHLClient _nhlClient = new NHLClient();

        [Fact]
        public async Task Test_GetCurrentAsync_ByRegularSeason_ReturnsRegularSeasonStandings()
        {
            var response = await _nhlClient.Standings.GetCurrentAsync();

            Assert.NotNull(response);
            // Should be 4 divisions
            Assert.True(response.Records.Count == 4);
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.RegularSeason));
        }

        [Fact]
        public async Task Test_GetCurrentAsync_ByDivision_ReturnsDivisionStandings()
        {
            var response = await _nhlClient.Standings.GetCurrentAsync(StandingsTypes.ByDivision);

            Assert.NotNull(response);
            // Should be 4 divisions
            Assert.True(response.Records.Count == 4);
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.ByDivision));
        }

        [Fact]
        public async Task Test_GetCurrentAsync_ByConference_ReturnsConferenceStandings()
        {
            var response = await _nhlClient.Standings.GetCurrentAsync(StandingsTypes.ByConference);

            Assert.NotNull(response);
            // Should be 2 conferences.
            Assert.True(response.Records.Count == 2);
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.ByConference));
        }

        [Fact]
        public async Task Test_GetBySeasonAsync_ReturnsRegularSeasonStandings()
        {
            var response = await _nhlClient.Standings.GetBySeasonAsync(Season);

            Assert.NotNull(response);
            Assert.True(response.Records.All(x => x.Season == Season));
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.RegularSeason));
        }

        [Fact]
        public async Task Test_GetBySeasonAsync_ByConference_ReturnsConferenceStandings()
        {
            var response = await _nhlClient.Standings.GetBySeasonAsync(Season, StandingsTypes.ByConference);

            Assert.NotNull(response);
            Assert.True(response.Records.All(x => x.Season == Season));
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.ByConference));
            // 2 Conferences
            Assert.True(response.Records.Count == 2);
        }

        [Fact]
        public async Task Test_GetBySeasonAsync_EmptyString_ReturnsNull()
        {
            var response = await _nhlClient.Standings.GetBySeasonAsync("");
            Assert.Null(response);
        }

        [Fact]
        public async Task Test_GetBySeasonAsync_InvalidSeason_ReturnsEmptyRecords()
        {
            var response = await _nhlClient.Standings.GetBySeasonAsync("89756702");
            Assert.True(response.Records.Count == 0);
        }

        [Fact]
        public void Test_GetCurrent_ByRegularSeason_ReturnsRegularSeasonStandings()
        {
            var response = _nhlClient.Standings.GetCurrent();

            Assert.NotNull(response);
            Assert.True(response.Records.Count == 4);
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.RegularSeason));
        }
    
        [Fact]
        public void Test_GetCurrent_ByDivision_ReturnsDivisionStandings()
        {
            var response = _nhlClient.Standings.GetCurrent(StandingsTypes.ByDivision);

            Assert.NotNull(response);
            // Should be 4 divisions
            Assert.True(response.Records.Count == 4);
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.ByDivision));
        }
   
        [Fact]
        public void Test_GetCurrent_ByConference_ReturnsConferenceStandings()
        {
            var response = _nhlClient.Standings.GetCurrent(StandingsTypes.ByConference);

            Assert.NotNull(response);
            // Should be 2 conferences.
            Assert.True(response.Records.Count == 2);
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.ByConference));
        }
    
        [Fact]
        public void Test_GetBySeason_ReturnsRegularSeasonStandings()
        {
            var response = _nhlClient.Standings.GetBySeason(Season);

            Assert.NotNull(response);
            Assert.True(response.Records.All(x => x.Season == Season));
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.RegularSeason));
        }

        [Fact]
        public void Test_GetBySeason_ByConference_ReturnsConferenceStandings()
        {
            var response = _nhlClient.Standings.GetBySeason(Season, StandingsTypes.ByConference);

            Assert.NotNull(response);
            Assert.True(response.Records.All(x => x.Season == Season));
            Assert.True(response.Records.All(x => x.StandingsType == StandingsTypes.ByConference));
        }

        [Fact]
        public void Test_GetBySeason_EmptyString_ReturnsNull()
        {
            var response = _nhlClient.Standings.GetBySeason("");

            Assert.Null(response);
        }
    
        [Fact]
        public void Test_GetBySeason_InvalidSeason_ReturnsEmptyRecords()
        {
            var response = _nhlClient.Standings.GetBySeason("89756702");
            Assert.True(response.Records.Count == 0);
        }
    }
}
