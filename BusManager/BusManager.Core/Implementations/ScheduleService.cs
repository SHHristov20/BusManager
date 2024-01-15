using BusManager.Core.Interfaces;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;

namespace BusManager.Core.Implementations
{
    public class ScheduleService : IScheduleService
    {
        private readonly ScheduleRepository _scheduleRepository;
        public ScheduleService(ScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public async Task<bool> CreateSchedule(Station fromStation, Station toStation, DateTime dateTime, float price)
        {
            Schedule schedule = new()
            {
                FromStation = fromStation,
                ToStation = toStation,
                Time = dateTime,
                Price = price
            };
            return await _scheduleRepository.CreateSchedule(schedule);
        }
        public async Task<List<Schedule>> GetAllSchedulesList()
        {
            return await _scheduleRepository.GetAllSchedules();
        }
        public async Task<Schedule?> GetLastAddedSchedule()
        {
            return await _scheduleRepository.GetLastAddedSchedule();
        }
        public async Task<bool> DeleteSchedule(Schedule schedule)
        {
            return await _scheduleRepository.DeleteSchedule(schedule);
        }
        public async Task<List<Schedule>> GetSchedulesForToday() 
        {
            return await _scheduleRepository.GetSchedulesForToday();
        }
        public async Task<List<Schedule>> GetSpecificSchedules(City from, City to, DateTime date) 
        {
            return await _scheduleRepository.GetSpecificSchedules(from, to, date);
        }
        public async Task<List<Schedule>> GetSchedulesForDate(DateTime date)
        {
            return await _scheduleRepository.GetSchedulesForDate(date);
        }
    }
}
