using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Data.Models
{
    public class Station
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public ICollection<Schedule> SchedulesFrom { get; set; } = null!;
        public ICollection<Schedule> SchedulesTo { get; set; } = null!;
    }
}
