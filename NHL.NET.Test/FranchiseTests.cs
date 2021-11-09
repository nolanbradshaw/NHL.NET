﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NHL.NET.Test
{
    public class FranchiseTests
    {
        private readonly NHLClient _nhlClient = new();

        [Fact]
        public async Task Test_GetAllAsync_ReturnsAllFranchises()
        {
            var response = await _nhlClient.Franchise.GetAllAsync();

            Assert.NotNull(response);
            Assert.NotNull(response.Franchises);
            Assert.True(response.Franchises.Count > 1);
        }

        [Fact]
        public void Test_GetAll_ReturnsAllFranchises()
        {
            var response = _nhlClient.Franchise.GetAll();

            Assert.NotNull(response);
            Assert.NotNull(response.Franchises);
            Assert.True(response.Franchises.Count > 1);
        }

        [Fact]
        public async Task Test_GetByIdAsync_ReturnsFranchise()
        {
            var response = await _nhlClient.Franchise.GetByIdAsync(5);

            Assert.NotNull(response);
            Assert.Equal("Maple Leafs", response.TeamName);
            Assert.Equal("Toronto", response.LocationName);
        }

        [Fact]
        public void Test_GetById_ReturnsFranchise()
        {
            var response = _nhlClient.Franchise.GetById(5);

            Assert.NotNull(response);
            Assert.Equal("Maple Leafs", response.TeamName);
            Assert.Equal("Toronto", response.LocationName);
        }

        [Fact]
        public async Task Test_GetMultipleAsync_ReturnsFranchises()
        {
            var response = await _nhlClient.Franchise.GetMultipleByIdAsync(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.NotNull(response.Franchises);
            Assert.True(response.Franchises.Count == 3);
        }

        [Fact]
        public void Test_GetMultiple_ReturnsFranchises()
        {
            var response = _nhlClient.Franchise.GetMultipleById(new List<int> { 1, 2, 3 });

            Assert.NotNull(response);
            Assert.NotNull(response.Franchises);
            Assert.True(response.Franchises.Count == 3);
        }
    }
}