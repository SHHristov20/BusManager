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
        public async Task<Station?> GetLastAddedStation()
        {
            return await _stationRepository.GetLastAddedStation();
        }
        public async Task<bool> CreateStation(string name, string address, string city)
        {
            City cityObj = await GetCityByName(city);
            Station station = new()
            {
                Name = name,
                Address = address,
                City = cityObj
            };
            return await _stationRepository.CreateStation(station);
        }
        public async Task<City?> GetCityByName(string name)
        {
            return await _cityRepository.GetCityByName(name);
        }
        public async Task<bool> DeleteStation(Station station)
        {
            return await _stationRepository.DeleteStation(station);
        }
        public async Task<Station?> GetStationById(int id)
        {
            return await _stationRepository.GetStationById(id);
        }

    }
}
