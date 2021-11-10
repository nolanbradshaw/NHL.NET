using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class DivisionTests
    {
        private readonly NHLClient _nhlClient = new();

        [Fact]
        public async Task Test_GetAllAsync_ReturnsAllDivisions()
        {
            var response = await _nhlClient.Division.GetAllAsync();

            Assert.NotNull(response);
            Assert.NotNull(response.Divisions);
            Assert.True(response.Divisions.Count > 0);
        }

        [Fact]
        public async Task Test_GetByIdAsync_ReturnsDivision()
        {
            var response = await _nhlClient.Division.GetByIdAsync(2);

            Assert.NotNull(response);
            Assert.NotNull(response.Conference);

            Assert.True(response.Id > 0);
            Assert.False(string.IsNullOrEmpty(response.Name));
        }

        [Fact]
        public async Task Test_GetMultipleAsync_ReturnsDivisions()
        {
            var response = await _nhlClient.Division.GetMultipleAsync(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.True(response.Divisions.Count == 3);
        }


        [Fact]
        public void Test_GetAll_ReturnsAllDivisions()
        {
            var response = _nhlClient.Division.GetAll();

            Assert.NotNull(response);
            Assert.NotNull(response.Divisions);
            Assert.True(response.Divisions.Count > 0);
        }

        [Fact]
        public void Test_GetById_ReturnsDivision()
        {
            var response = _nhlClient.Division.GetById(2);

            Assert.NotNull(response);
            Assert.NotNull(response.Conference);

            Assert.True(response.Id > 0);
            Assert.False(string.IsNullOrEmpty(response.Name));
        }

        [Fact]
        public void Test_GetMultiple_ReturnsDivisions()
        {
            var response = _nhlClient.Division.GetMultiple(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.True(response.Divisions.Count == 3);
        }
    }
}
