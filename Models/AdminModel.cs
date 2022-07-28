using System.ComponentModel.DataAnnotations;

namespace NamiMarket.Models
{
    public class AdminModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Password { get; set; }
    }
}