using System.ComponentModel.DataAnnotations;

namespace BusManager.Data.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Station> Stations { get; set; } = null!;

    }
}
