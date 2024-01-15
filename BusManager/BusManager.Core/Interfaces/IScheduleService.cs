using BusManager.Data.Models;

namespace BusManager.Core.Interfaces
{
    public interface IScheduleService
    {
        Task<bool> CreateSchedule(Station toStation, Station fromStation, DateTime dateTime, float price);
        Task<List<Schedule>> GetAllSchedulesList();
        Task<Schedule?> GetLastAddedSchedule();
        Task<bool> DeleteSchedule(Schedule schedule);
        Task<List<Schedule>> GetSchedulesForToday();
        Task<List<Schedule>> GetSpecificSchedules(City from, City to, DateTime date);
        Task<List<Schedule>> GetSchedulesForDate(DateTime date);
    }
}
