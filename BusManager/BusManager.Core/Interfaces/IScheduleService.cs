using BusManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
