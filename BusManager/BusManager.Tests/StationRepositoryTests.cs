using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusManager.Data.Data.Contexts;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace BusManager.Tests
{
    [TestFixture]
    public class StationRepositoryTests
    {
        private BusManagerDbContext _dbContext;
        private StationRepository _stationRepository;

        [SetUp]
        public void Setup()
        {
            _dbContext = new BusManagerDbContext();
            _stationRepository = new StationRepository(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
        }

        [Test]
        public async Task GetLastAddedStation_ShouldReturnLastAddedStation()
        {
            // Arrange
            await _dbContext.Stations.AddRangeAsync(
                new Station { Name = "Station1", Address = "Address1", CityId = 1 },
                new Station { Name = "Station2", Address = "Address2", CityId = 1 },
                new Station { Name = "Station3", Address = "Address3", CityId = 1 }
            );
            await _dbContext.SaveChangesAsync();

            // Act
            var lastStation = await _stationRepository.GetLastAddedStation();

            // Assert
            Assert.NotNull(lastStation);
            Assert.AreEqual("Station3", lastStation?.Name);
        }

        [Test]
        public async Task CreateStation_ShouldCreateStationInDatabase()
        {
            // Arrange
            var station = new Station { Name = "NewStation", Address = "NewAddress", CityId = 1 };

            // Act
            var result = await _stationRepository.CreateStation(station);

            // Assert
            Assert.IsTrue(result);

            var createdStation = await _dbContext.Stations.FirstOrDefaultAsync(s => s.Name == "NewStation");
            Assert.NotNull(createdStation);
        }

        [Test]
        public async Task DeleteStation_ShouldDeleteStationFromDatabase()
        {
            // Arrange
            var station = new Station { Name = "StationToDelete", Address = "AddressToDelete", CityId = 1 };
            await _dbContext.Stations.AddAsync(station);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _stationRepository.DeleteStation(station);

            // Assert
            Assert.IsTrue(result);
            var deletedStation = await _dbContext.Stations.FirstOrDefaultAsync(s => s.Name == "StationToDelete");
            Assert.Null(deletedStation);
        }

        [Test]
        public async Task GetStationById_ShouldReturnNullForNonExistingStation()
        {
            // Arrange
            var stationId = 999;

            // Act
            var station = await _stationRepository.GetStationById(stationId);

            // Assert
            Assert.Null(station);
        }
    }
}
