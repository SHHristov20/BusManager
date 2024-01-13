using System.ComponentModel.DataAnnotations;

namespace BusManager.Data.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public float Price { get; set; }

        public int FromStationId { get; set; }
        public Station FromStation { get; set; } = null!;

        public int ToStationId { get; set; }
        public Station ToStation { get; set; } = null!;

        public ICollection<Ticket> Tickets { get; set; } = null!;
    }
}
