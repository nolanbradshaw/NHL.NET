using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class TeamTests
    {
        private readonly NHLClient _nhlClient = new();

        [Fact]
        public async Task Test_GetAllAsync_ReturnsAllTeams()
        {
            var response = await _nhlClient.Team.GetAllAsync();

            Assert.NotNull(response);
            Assert.NotNull(response.Teams);
            Assert.True(response.Teams.Count > 31);
        }

        [Fact]
        public async Task Test_GetByIdAsync_ReturnsTeam()
        {
            var response = await _nhlClient.Team.GetByIdAsync(6);

            Assert.NotNull(response);
            Assert.Equal("Boston", response.LocationName);
            Assert.Equal("Bruins", response.TeamName);
        }

        [Fact]
        public async Task Test_GetMultipleAsync_ReturnsTeamList()
        {
            var response = await _nhlClient.Team.GetMultipleAsync(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.True(response.Teams.Count == 3);
        }
    }
}
