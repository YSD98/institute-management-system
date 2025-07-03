using System.ComponentModel.DataAnnotations;

namespace INSTITUTE_MANAGEMENT_SYSTEM.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Password { get; set; }
    }
}
