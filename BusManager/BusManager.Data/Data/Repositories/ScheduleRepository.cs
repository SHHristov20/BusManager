using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Data.Data.Repositories
{
    public class ScheduleRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public ScheduleRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateSchedule(Schedule schedule)
        {
            try
            {
                await _dbContext.Schedules.AddAsync(schedule);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<List<Schedule>> GetAllSchedules()
        {
            return await _dbContext.Schedules
                .Include(s => s.FromStation)
                .Include(s => s.ToStation)
                .Include(s => s.FromStation.City)
                .Include(s => s.ToStation.City)
                .ToListAsync();
        }
        public async Task<Schedule?> GetLastAddedSchedule()
        {
            return await _dbContext.Schedules
                .OrderByDescending(s => s.Id)
                .FirstOrDefaultAsync();
        }
        public async Task<bool> DeleteSchedule(Schedule schedule)
        {
            try
            {
                _dbContext.Schedules.Remove(schedule);
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
