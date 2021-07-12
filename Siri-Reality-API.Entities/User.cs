using System.ComponentModel.DataAnnotations;
using Siri_Reality_API.Entities.Enums;

namespace Siri_Reality_API.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public UserType Type { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public Gender? Gender { get; set; }

        public string Email { get; set; }

        public Status Status { get; set; } = Status.Active;
    }
}
