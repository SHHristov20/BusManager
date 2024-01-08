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
        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await _context.Cities.ToListAsync();
        }
    }
}
