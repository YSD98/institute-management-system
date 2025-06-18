using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Username { get; set; }

        [Required]
        public string? PasswordHash { get; set; }
    }
}
