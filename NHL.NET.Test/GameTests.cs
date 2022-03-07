using NHL.NET.Exceptions;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class GameTests
    {
        private readonly NHLClient _nhlClient = new NHLClient();

        [Fact]
        public async Task Test_GetBoxscoreAsync_ReturnsBoxscore()
        {
            var response = await _nhlClient.Games.GetBoxscoreAsync("2021020271");
            Assert.NotNull(response);

            Assert.NotNull(response.Home.Stats);
            Assert.NotNull(response.Away.Stats);
        }

        [Fact]
        public async Task Test_GetBoxscoreAsync_GameNotFound()
        {
            var exception = await Assert.ThrowsAsync<NHLClientRequestException>(async () => await _nhlClient.Games.GetBoxscoreAsync("0892020971"));
            Assert.Equal((int)HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Fact]
        public async Task Test_GetBoxscoreAsync_EmptyString()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await _nhlClient.Games.GetBoxscoreAsync(""));
        }

        [Fact]
        public void Test_GetBoxscore_ReturnsBoxscore()
        {
            var response = _nhlClient.Games.GetBoxscore("2021020271");
            Assert.NotNull(response);

            Assert.NotNull(response.Home.Stats);
            Assert.NotNull(response.Away.Stats);
        }

        [Fact]
        public void Test_GetBoxscore_GameNotFound()
        {
            var exception = Assert.Throws<NHLClientRequestException>(() => _nhlClient.Games.GetBoxscore("0892020971"));
            Assert.Equal((int)HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Fact]
        public void Test_GetBoxscore_EmptyString()
        {
            Assert.Throws<ArgumentNullException>(() => _nhlClient.Games.GetBoxscore(""));
        }
    }
}
