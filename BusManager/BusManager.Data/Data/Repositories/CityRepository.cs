using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Data.Data.Repositories
{
    public class CityRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public CityRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<City>> GetAllCities()
        {
            return await _dbContext.Cities.ToListAsync();
        }
        public async Task<City> GetCityByName(string name)
        {
            return await _dbContext.Cities
                .Where(c => c.Name == name)
                .FirstOrDefaultAsync();
        }
    }
}
