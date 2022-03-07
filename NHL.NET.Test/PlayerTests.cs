using NHL.NET.Exceptions;
using System;
using System.Net;
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
        public async Task Test_GetStatsBySeasonAsync_NoSeason_ThrowsArgumentNullException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await _nhlClient.Players.GetStatsBySeasonAsync(8470604, ""));
        }

        [Fact]
        public async Task Test_GetStatsBySeasonAsync_NoPlayerFound_ThrowsNHLClientRequestException()
        {
            var exception = await Assert.ThrowsAsync<NHLClientRequestException>(async () => await _nhlClient.Players.GetStatsBySeasonAsync(2238566, "20162017"));
            // For some reason the NHL API returns a 500 instead of a 404
            Assert.Equal((int)HttpStatusCode.InternalServerError, exception.StatusCode);
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

        [Fact]
        public async Task Test_GetStatsBySeason_NoPlayerFound_ThrowsNHLClientRequestException()
        {
            var exception = Assert.Throws<NHLClientRequestException>(() => _nhlClient.Players.GetStatsBySeason(2238566, "20162017"));
            // For some reason the NHL API returns a 500 instead of a 404
            Assert.Equal((int)HttpStatusCode.InternalServerError, exception.StatusCode);
        }

        [Fact]
        public void Test_GetStatsBySeason_NoSeason_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _nhlClient.Players.GetStatsBySeason(8470604, ""));
        }
    }
}
