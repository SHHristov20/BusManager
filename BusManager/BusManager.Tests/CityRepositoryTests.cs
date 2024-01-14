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
    public class CityRepositoryTests
    {
        private BusManagerDbContext _dbContext;
        private CityRepository _cityRepository;

        [SetUp]
        public void Setup()
        {
            _dbContext = new BusManagerDbContext();
            _cityRepository = new CityRepository(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
        }

        [Test]
        public async Task GetCityByName_ShouldReturnCityIfExists()
        {
            // Arrange
            var cityName = "TestCity";
            await _dbContext.Cities.AddAsync(new City { Name = cityName });
            await _dbContext.SaveChangesAsync();

            // Act
            var city = await _cityRepository.GetCityByName(cityName);

            // Assert
            Assert.NotNull(city);
            Assert.AreEqual(cityName, city?.Name);
        }

        [Test]
        public async Task GetCityByName_ShouldReturnNullForNonExistingCity()
        {
            // Arrange
            var cityName = "NonExistingCity";

            // Act
            var city = await _cityRepository.GetCityByName(cityName);

            // Assert
            Assert.Null(city);
        }
    }
}
