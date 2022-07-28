using System.ComponentModel.DataAnnotations;

namespace NamiMarket.Dtos
{
    public class FinanceCreateDto
    {
        [Required]
        [MaxLength(10)]
        public string? Fina_ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string? First_Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Last_Name { get; set; }

        [Required]
        [MaxLength(1)]
        public string? Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Phone_Number { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Country { get; set; }

        [Required]
        [MaxLength(25)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Password { get; set; }
    }
}