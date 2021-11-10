using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class ConferenceTests
    {
        private readonly NHLClient _nhlClient = new();

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
        public void Test_GetMultiple_ReturnsConferences()
        {
            var response = _nhlClient.Conferences.GetMultiple(new List<int> { 1, 2 });

            Assert.NotNull(response);
            Assert.True(response.Conferences.Count == 2);
        }
    }
}
