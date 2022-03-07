using NHL.NET.Exceptions;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class TeamTests
    {
        private readonly NHLClient _nhlClient = new NHLClient();

        [Fact]
        public async Task Test_GetAllAsync_ReturnsAllTeams()
        {
            var response = await _nhlClient.Teams.GetAllAsync();

            Assert.NotNull(response);
            Assert.NotNull(response.Teams);
            Assert.True(response.Teams.Count > 31);
        }

        [Fact]
        public async Task Test_GetByIdAsync_ReturnsTeam()
        {
            var response = await _nhlClient.Teams.GetByIdAsync(6);

            Assert.NotNull(response);
            Assert.Equal("Boston", response.LocationName);
            Assert.Equal("Bruins", response.TeamName);
            Assert.NotNull(response.Roster);
        }

        [Fact]
        public async Task Test_GetByIdAsync_NoTeamFound_ThrowsNHLClientRequestException()
        {
            var exception = await Assert.ThrowsAsync<NHLClientRequestException>(async () => await _nhlClient.Teams.GetByIdAsync(62354));
            Assert.Equal((int)HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Fact]
        public async Task Test_GetTeamStatsAsync_ReturnsTeamStats()
        {
            var response = await _nhlClient.Teams.GetStatsAsync(5);
            Assert.NotNull(response);
        }

        [Fact]
        public async Task Test_GetTeamStatsAsync_SpecificSeason_ReturnsTeamStats()
        {
            // Compare 2 different seasons to verify different stats were returned.
            var firstSeason = await _nhlClient.Teams.GetStatsAsync(5, "20102011");
            var secondSeason = await _nhlClient.Teams.GetStatsAsync(5, "20092010");

            Assert.NotNull(firstSeason);
            Assert.NotNull(secondSeason);

            Assert.NotEqual(firstSeason.Wins, secondSeason.Wins);
            Assert.NotEqual(firstSeason.GoalsPerGame, secondSeason.GoalsPerGame);
        }

        [Fact]
        public async Task Test_GetTeamStatsAsync_EmptySeason_ReturnsTeamStats()
        {
            var response = await _nhlClient.Teams.GetStatsAsync(5, "");

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Test_GetMultipleAsync_ReturnsTeamList()
        {
            var response = await _nhlClient.Teams.GetMultipleAsync(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.True(response.Teams.Count == 3);
            // Verifying roster is returned
            Assert.NotNull(response.Teams[0].Roster);
        }

        [Fact]
        public void Test_GetAll_ReturnsAllTeams()
        {
            var response = _nhlClient.Teams.GetAll();

            Assert.NotNull(response);
            Assert.NotNull(response.Teams);
            Assert.True(response.Teams.Count > 31);
        }

        [Fact]
        public void Test_GetById_ReturnsTeam()
        {
            var response = _nhlClient.Teams.GetById(6);

            Assert.NotNull(response);
            Assert.Equal("Boston", response.LocationName);
            Assert.Equal("Bruins", response.TeamName);
            Assert.NotNull(response.Roster);
        }

        [Fact]
        public void Test_GetById_NoTeamFound_ThrowsNHLClientRequestException()
        {
            var exception = Assert.Throws<NHLClientRequestException>(() => _nhlClient.Teams.GetById(62354));
            Assert.Equal((int)HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Fact]
        public void Test_GetMultiple_ReturnsTeamList()
        {
            var response = _nhlClient.Teams.GetMultiple(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.True(response.Teams.Count == 3);
            Assert.NotNull(response.Teams[0].Roster);
        }

        [Fact]
        public void Test_GetTeamStats_ReturnsTeamStats()
        {
            var response = _nhlClient.Teams.GetStats(5);

            Assert.NotNull(response);
        }

        [Fact]
        public void Test_GetTeamStats_SpecificSeason_ReturnsTeamStats()
        {
            // Compare 2 different seasons to verify different stats were returned.
            var firstSeason = _nhlClient.Teams.GetStats(5, "20102011");
            var secondSeason = _nhlClient.Teams.GetStats(5, "20092010");

            Assert.NotNull(firstSeason);
            Assert.NotNull(secondSeason);

            Assert.NotEqual(firstSeason.Wins, secondSeason.Wins);
            Assert.NotEqual(firstSeason.GoalsPerGame, secondSeason.GoalsPerGame);
        }

        [Fact]
        public void Test_GetTeamStats_EmptySeason_ReturnsTeamStats()
        {
            var response = _nhlClient.Teams.GetStats(5, "");

            Assert.NotNull(response);
        }
    }
}
