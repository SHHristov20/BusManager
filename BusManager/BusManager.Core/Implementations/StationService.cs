using BusManager.Core.Interfaces;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Core.Implementations
{
    public class StationService : IStationService
    {
        private readonly CityRepository _cityRepository;
        private readonly StationRepository _stationRepository;
        public StationService(CityRepository cityRepository, StationRepository stationRepository)
        {
            _cityRepository = cityRepository;
            _stationRepository = stationRepository;
        }
        public async Task<List<String>> GetAllCitiesStrings()
        {
            List<City> cities = await _cityRepository.GetAllCities();
            List<String> result = new List<String>();
            foreach (City c in cities)
            {
                result.Add(c.Name);
            }
            return result;
        }
        public async Task<List<Station>> GetAllStationsList()
        {
            return await _stationRepository.GetAllStations();
        }
    }
}
