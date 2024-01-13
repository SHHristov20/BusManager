using System.ComponentModel.DataAnnotations;

namespace BusManager.Data.Models
{
    public class UserType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<User> Users { get; set; } = null!;
    }
}
