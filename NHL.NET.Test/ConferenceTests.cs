using NHL.NET.Exceptions;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class ConferenceTests
    {
        private readonly NHLClient _nhlClient = new NHLClient();

        [Fact]
        public async Task Test_GetAllAsync_ReturnsConferences()
        {
            var response = await _nhlClient.Conferences.GetAllAsync();

            Assert.NotNull(response);
            Assert.True(response.Conferences.Count > 0);
        }

        [Fact]
        public async Task Test_GetByIdAsync_ReturnsConference()
        {
            var response = await _nhlClient.Conferences.GetByIdAsync(1);

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Test_GetByIdAsync_NoConferenceFound_ThrowsNHLClientRequestException()
        {
            var exception = await Assert.ThrowsAsync<NHLClientRequestException>(async () => await _nhlClient.Conferences.GetByIdAsync(395581));
            Assert.Equal((int)HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Fact]
        public async Task Test_GetMultipleAsync_ReturnsConferences()
        {
            var response = await _nhlClient.Conferences.GetMultipleAsync(new List<int> { 1, 2 });

            Assert.NotNull(response);
            Assert.True(response.Conferences.Count == 2);
        }

        [Fact]
        public void Test_GetAll_ReturnsConferences()
        {
            var response = _nhlClient.Conferences.GetAll();

            Assert.NotNull(response);
            Assert.True(response.Conferences.Count > 0);
        }

        [Fact]
        public void Test_GetById_ReturnsConference()
        {
            var response = _nhlClient.Conferences.GetById(1);

            Assert.NotNull(response);
        }

        [Fact]
        public void Test_GetById_NoConferenceFound_ThrowsNHLClientRequestException()
        {
            var exception = Assert.Throws<NHLClientRequestException>(() => _nhlClient.Conferences.GetById(395581));
            Assert.Equal((int)HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Fact]
        public void Test_GetMultiple_ReturnsConferences()
        {
            var response = _nhlClient.Conferences.GetMultiple(new List<int> { 1, 2 });

            Assert.NotNull(response);
            Assert.True(response.Conferences.Count == 2);
        }
    }
}
