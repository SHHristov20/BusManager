using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;

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
                .OrderByDescending(s => s.Time)
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
        public async Task<List<Schedule>> GetSchedulesForToday()
        {
            DateTime now = DateTime.Now;
            DateTime endOfDay = now.Date.AddDays(1).AddTicks(-1);
            return await _dbContext.Schedules
                .Where(s => s.Time > now && s.Time < endOfDay)
                .Include(s => s.FromStation)
                .Include(s => s.ToStation)
                .Include(s => s.FromStation.City)
                .Include(s => s.ToStation.City)
                .OrderBy(s => s.Time)
                .ToListAsync();
        }
        public async Task<List<Schedule>> GetSpecificSchedules(City from, City to, DateTime date)
        {
            DateTime startOfDay = date.Date;
            DateTime endOfDay = startOfDay.AddDays(1).AddTicks(-1);
            return await _dbContext.Schedules
                .Where(s => s.FromStation.City == from && 
                    s.ToStation.City == to && 
                    s.Time > startOfDay && 
                    s.Time < endOfDay)
                .Include(s => s.FromStation)
                .Include(s => s.ToStation)
                .Include(s => s.FromStation.City)
                .Include(s => s.ToStation.City)
                .OrderBy(s => s.Time)
                .ToListAsync();
        }
        public async Task<List<Schedule>> GetSchedulesForDate(DateTime date)
        {
            DateTime startOfDay = date.Date;
            DateTime endOfDay = startOfDay.AddDays(1).AddTicks(-1);
            return await _dbContext.Schedules
                .Where(s => s.Time > startOfDay &&
                    s.Time < endOfDay)
                .Include(s => s.FromStation)
                .Include(s => s.ToStation)
                .Include(s => s.FromStation.City)
                .Include(s => s.ToStation.City)
                .OrderBy(s => s.Time)
                .ToListAsync();
        }
    }
}
