using System.ComponentModel.DataAnnotations;

namespace NamiMarket.Dtos
{
    public class AdminUpdateDto
    {
        [Required]
        [MaxLength(10)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Password { get; set; }
    }
}