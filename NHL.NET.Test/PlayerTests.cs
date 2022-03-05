using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class PlayerTests
    {
        private readonly NHLClient _nhlClient = new NHLClient();

        [Fact]
        public async Task Test_GetStatsBySeasonAsync_SingleRegularSeason_ReturnsPlayerStats()
        {
            // Jeff Carter
            var response = await _nhlClient.Players.GetStatsBySeasonAsync(8470604, "20162017");

            Assert.NotNull(response);
            // We are only expecting a single season with a single split.
            Assert.True(response.Stats.Count == 1);
            Assert.True(response.Stats[0].Splits.Count == 1);
        }

        [Fact]
        public void Test_GetStatsBySeason_SingleRegularSeason_ReturnsPlayerStats()
        {
            // Jeff Carter
            var response = _nhlClient.Players.GetStatsBySeason(8470604, "20162017");

            Assert.NotNull(response);
            // We are only expecting a single season with a single split.
            Assert.True(response.Stats.Count == 1);
            Assert.True(response.Stats[0].Splits.Count == 1);
        }

        [Fact]
        public async Task Test_GetByIdAsync_ReturnsPlayer()
        {
            var response = await _nhlClient.Players.GetByIdAsync(8477474);

            Assert.NotNull(response);
        }

        [Fact]
        public void Test_GetById_ReturnsPlayer()
        {
            var response = _nhlClient.Players.GetById(8477474);
            Assert.NotNull(response);
        }
    }
}
