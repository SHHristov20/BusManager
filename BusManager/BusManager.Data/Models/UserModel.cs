using System.ComponentModel.DataAnnotations;

namespace BusManager.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; } = null!;

        public ICollection<Ticket> Tickets { get; set; } = null!;
    }
}
