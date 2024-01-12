using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BusManager.Data.Data.Repositories
{
    public class StationRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public StationRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Station>> GetAllStations()
        {
            return await _dbContext.Stations
                .Include(s => s.City)
                .ToListAsync();
        }
        public async Task<Station?> GetLastAddedStation()
        {
            return await _dbContext.Stations
                .OrderByDescending(e => e.Id)
                .FirstOrDefaultAsync();
        }
        public async Task<bool> CreateStation(Station station)
        {
            try
            {
                await _dbContext.Stations.AddAsync(station);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteStation(Station station)
        {
            try
            {
                _dbContext.Stations.Remove(station);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<Station?> GetStationById(int id)
        {
            return await _dbContext.Stations
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
