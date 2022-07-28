using System.ComponentModel.DataAnnotations;

namespace NamiMarket.Dtos
{
    public class PaymentCreateDto
    {
        [Required]
        [MaxLength(10)]
        public string? Fina_ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Cust_ID { get; set; }

        [Required]
        [MaxLength(40)]
        public string? Cust_Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string? TypeOfPay { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Num_Stand { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Amount_Pay { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}