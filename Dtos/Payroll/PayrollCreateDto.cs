using System.ComponentModel.DataAnnotations;

namespace NamiMarket.Dtos
{
    public class PayrollCreateDto
    {
        [Required]
        [MaxLength(10)]
        public string? Employee_ID { get; set; }

        [Required]
        [MaxLength(40)]
        public string? Employee_Name { get; set; }

        [Required]
        [MaxLength(360)]
        public string? Total_Days { get; set; }

        [Required]
        public string? Salary { get; set; }

        [Required]
        [MaxLength(360)]
        public string? Days_Works { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}