using System.ComponentModel.DataAnnotations;

namespace BusManager.Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } = null!;

        public int BuyerId { get; set; }
        public User Buyer { get; set; } = null!;

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; } = null!;

    }
}
