using BusManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Core.Interfaces
{
    public interface IStationService
    {
        Task<List<String>> GetAllCitiesStrings();
        Task<List<Station>> GetAllStationsList();
        Task<bool> CreateStation(string name, string address, string city);
        Task<Station?> GetLastAddedStation();
        Task<City?> GetCityByName(string name);
        Task<bool> DeleteStation(Station station);
        Task<Station?> GetStationById(int id);
    }
}
