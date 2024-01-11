﻿using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await _dbContext.Stations.ToListAsync();
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
    }
}
